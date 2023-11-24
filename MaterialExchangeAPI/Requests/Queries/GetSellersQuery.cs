using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetSellersQuery : IRequest<List<Seller>>
    {

    }
}
