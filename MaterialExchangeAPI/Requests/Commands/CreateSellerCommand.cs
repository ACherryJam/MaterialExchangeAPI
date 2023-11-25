using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class CreateSellerCommand(
        string Name    
    ) : IRequest<Seller>
    {
    }
}
