using Mapster;
using MaterialExchangeAPI.Data;
using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class CreateMaterialCommandHandler : IRequestHandler<CreateMaterialCommand, Material>
    {
        private readonly DataContext _context;
        private readonly IMaterialRepository _repository;

        public CreateMaterialCommandHandler(IMaterialRepository repository, DataContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<Material> Handle(CreateMaterialCommand command, CancellationToken cancellationToken)
        {
            Material material = command.Adapt<Material>();

            _repository.Insert(material);
            await _repository.Save();
            await _context.Materials.Entry(material).GetDatabaseValuesAsync();

            return material;
        }
    }
}
