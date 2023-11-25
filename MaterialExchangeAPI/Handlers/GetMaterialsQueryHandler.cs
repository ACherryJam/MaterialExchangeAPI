using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetMaterialsQueryHandler : IRequestHandler<GetMaterialsQuery, List<Material>>
    {
        private readonly IMaterialRepository _repository;

        public GetMaterialsQueryHandler(IMaterialRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Material>> Handle(GetMaterialsQuery query, CancellationToken cancellationToken)
        {
            List<Material> materials = await _repository.GetAsync();
            return materials;
        }
    }
}
