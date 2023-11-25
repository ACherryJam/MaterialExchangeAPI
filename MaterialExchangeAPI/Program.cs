using MaterialExchangeAPI.Data;
using MaterialExchangeAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using FluentValidation;
using Hangfire;
using Hangfire.PostgreSql;
using MaterialExchangeAPI.Jobs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(
    cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
);

builder.Services.AddDbContext<DataContext>(
    options => {
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
);

builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();

builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

builder.Services.AddHangfire(
    cfg => {
        cfg.SetDataCompatibilityLevel(CompatibilityLevel.Version_180);
        cfg.UseSimpleAssemblyNameTypeSerializer();
        cfg.UseRecommendedSerializerSettings();
        cfg.UsePostgreSqlStorage(
            options => options.UseNpgsqlConnection(builder.Configuration.GetConnectionString("HangfireConnection"))
        );

        RecurringJob.AddOrUpdate<UpdateMaterialPriceJob>(
            "Update Material Prices", 
            job => job.Execute(), 
            Cron.Daily(8)
        );
    }
);
builder.Services.AddHangfireServer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHangfireDashboard();

app.MapControllers();

app.Run();
