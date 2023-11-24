using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetSellerByIdQuery(int Id) : IRequest<Seller>
    {
        
    }
}
