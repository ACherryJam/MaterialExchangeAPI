using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetSellersQueryHandler : IRequestHandler<GetSellersQuery, List<Seller>>
    {
        public GetSellersQueryHandler()
        {

        }

        public async Task<List<Seller>> Handle(GetSellersQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
