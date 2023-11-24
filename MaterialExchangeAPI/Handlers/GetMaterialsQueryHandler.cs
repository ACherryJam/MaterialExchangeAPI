using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetMaterialsQueryHandler : IRequestHandler<GetMaterialsQuery, List<Material>>
    {
        public GetMaterialsQueryHandler() 
        {
        
        }

        public async Task<List<Material>> Handle(GetMaterialsQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
