using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public record class GetMaterialsQuery : IRequest<List<Material>>
    {

    }
}
