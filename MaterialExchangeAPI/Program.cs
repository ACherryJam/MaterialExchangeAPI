using MaterialExchangeAPI.Data;
using MaterialExchangeAPI.Data.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(
    cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
);

builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
