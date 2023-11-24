using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetSellersQueryHandler : IRequestHandler<GetSellersQuery, List<Seller>>
    {
        private readonly ISellerRepository _repository;

        public GetSellersQueryHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Seller>> Handle(GetSellersQuery query, CancellationToken cancellationToken)
        {
            List<Seller> sellers = await _repository.Get();
            return sellers;
        }
    }
}
