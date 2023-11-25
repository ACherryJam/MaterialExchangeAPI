using MediatR;
using MaterialExchangeAPI.Models;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class UpdateMaterialCommand(
        int Id,
        string Name,
        decimal Price,
        int? SellerId
    ) : IRequest<Material>
    {

    }
}
