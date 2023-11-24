using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public class GetSellerByIdQuery : IRequest<Seller>
    {
        public int Id { get; set; }
    }
}
