using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetMaterialsQuery : IRequest<List<Material>>
    {

    }
}
