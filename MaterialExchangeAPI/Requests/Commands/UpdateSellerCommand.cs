using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class UpdateSellerCommand(
        int Id,
        string Name
    ) : IRequest<Seller>
    {

    }
}
