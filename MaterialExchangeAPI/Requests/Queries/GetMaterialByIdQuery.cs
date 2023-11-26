using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetMaterialByIdQuery(int Id) : IRequest<Material>
    {

    }
}
