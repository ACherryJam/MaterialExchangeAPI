using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetSellerByIdQueryHandler : IRequestHandler<GetSellerByIdQuery, Seller>
    {
        public GetSellerByIdQueryHandler()
        {

        }

        public async Task<Seller> Handle(GetSellerByIdQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
