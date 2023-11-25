using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetMaterialByIdQueryHandler : IRequestHandler<GetMaterialByIdQuery, Material>
    {
        private readonly IMaterialRepository _repository;

        public GetMaterialByIdQueryHandler(IMaterialRepository repository) 
        {
            _repository = repository;
        }

        public async Task<Material?> Handle(GetMaterialByIdQuery query, CancellationToken cancellationToken)
        {
            Material? material = await _repository.GetByIdAsync(query.Id);
            return material;
        }
    }
}
