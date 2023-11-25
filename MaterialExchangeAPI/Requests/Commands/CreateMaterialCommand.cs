using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class CreateMaterialCommand(
        string Name,
        decimal Price,
        int SellerId
    ) : IRequest<Material>
    {
    }
}
