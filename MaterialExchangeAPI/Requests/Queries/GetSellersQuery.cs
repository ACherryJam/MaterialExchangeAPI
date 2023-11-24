using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Queries
{
    public class GetSellersQuery : IRequest<List<Seller>>
    {

    }
}
