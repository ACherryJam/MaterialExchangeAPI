using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetMaterialByIdQuery(int Id) : IRequest<Material>
    {

    }
}
