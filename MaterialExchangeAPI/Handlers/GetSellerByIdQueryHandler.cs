using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class GetSellerByIdQueryHandler : IRequestHandler<GetSellerByIdQuery, Seller>
    {
        private readonly ISellerRepository _repository;

        public GetSellerByIdQueryHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Seller?> Handle(GetSellerByIdQuery query, CancellationToken cancellationToken)
        {
            Seller? seller = await _repository.GetByIdAsync(query.Id);
            return seller;
        }
    }
}
