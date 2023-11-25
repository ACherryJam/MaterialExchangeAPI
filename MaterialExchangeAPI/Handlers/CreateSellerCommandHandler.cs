using Mapster;
using MaterialExchangeAPI.Data;
using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class CreateSellerCommandHandler : IRequestHandler<CreateSellerCommand, Seller>
    {
        private readonly DataContext _context;
        private readonly ISellerRepository _repository;

        public CreateSellerCommandHandler(ISellerRepository repository, DataContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<Seller> Handle(CreateSellerCommand command, CancellationToken cancellationToken)
        {
            Seller seller = command.Adapt<Seller>();

            _repository.Insert(seller);
            await _repository.SaveAsync();
            await _context.Sellers.Entry(seller).GetDatabaseValuesAsync();

            return seller;
        }
    }
}
