using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MediatR;

namespace MaterialExchangeAPI.Handlers
{
    public class DeleteSellerCommandHandler : IRequestHandler<DeleteSellerCommand, Seller>
    {
        private readonly ISellerRepository _repository;

        public DeleteSellerCommandHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Seller?> Handle(DeleteSellerCommand command, CancellationToken cancellationToken)
        {
            Seller? seller = await _repository.GetByIdAsync(command.Id);
            if (seller == null)
                return null;

            _repository.Delete(command.Id);
            await _repository.SaveAsync();

            return seller;
        }
    }
}
