using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Queries
{
    public class GetMaterialsQuery : IRequest<List<Material>>
    {

    }
}
