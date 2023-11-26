using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetSellerByIdQuery(int Id) : IRequest<Seller>
    {
        
    }
}
