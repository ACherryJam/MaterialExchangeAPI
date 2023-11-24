using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetMaterialByIdQueryHandler : IRequestHandler<GetMaterialByIdQuery, Material>
    {
        public GetMaterialByIdQueryHandler() 
        {
            
        }

        public async Task<Material> Handle(GetMaterialByIdQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
