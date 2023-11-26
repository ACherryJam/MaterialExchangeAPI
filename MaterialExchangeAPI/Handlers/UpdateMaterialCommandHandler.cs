using Mapster;
using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class UpdateMaterialCommandHandler : IRequestHandler<UpdateMaterialCommand, Material>
    {
        private readonly IMaterialRepository _repository;

        public UpdateMaterialCommandHandler(IMaterialRepository repository)
        {
            _repository = repository;
        }

        public async Task<Material?> Handle(UpdateMaterialCommand command, CancellationToken cancellationToken)
        {
            if (!_repository.Exists(command.Id))
                return null;

            Material material = command.Adapt<Material>();

            _repository.Update(material);
            await _repository.SaveAsync();

            return material;
        }
    }
}
