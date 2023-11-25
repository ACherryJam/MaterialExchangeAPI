using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class DeleteMaterialCommandHandler : IRequestHandler<DeleteMaterialCommand, Material>
    {
        private readonly IMaterialRepository _repository;

        public DeleteMaterialCommandHandler(IMaterialRepository repository)
        {
            _repository = repository;
        }

        public async Task<Material?> Handle(DeleteMaterialCommand command, CancellationToken cancellationToken)
        {
            Material? material = await _repository.GetById(command.Id);
            if (material == null)
                return null;

            _repository.Delete(command.Id);
            await _repository.Save();

            return material;
        }
    }
}
