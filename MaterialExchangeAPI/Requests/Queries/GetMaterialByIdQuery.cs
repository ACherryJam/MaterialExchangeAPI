using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public class GetMaterialByIdQuery : IRequest<Material>
    {
        public int Id { get; set; }
    }
}
