using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class DeleteSellerCommand(int Id) : IRequest<Seller>
    {

    }
}
