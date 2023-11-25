using Mapster;
using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class UpdateSellerCommandHandler : IRequestHandler<UpdateSellerCommand, Seller>
    {
        private readonly ISellerRepository _repository;

        public UpdateSellerCommandHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Seller?> Handle(UpdateSellerCommand command, CancellationToken cancellationToken)
        {
            if (_repository.Exists(command.Id))
                return null;

            Seller seller = command.Adapt<Seller>();

            _repository.Update(seller);
            await _repository.SaveAsync();

            return seller;
        }
    }
}
