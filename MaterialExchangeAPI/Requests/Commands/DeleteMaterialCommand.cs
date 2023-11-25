using MaterialExchangeAPI.Models;
using MediatR;

namespace MaterialExchangeAPI.Requests.Commands
{
    public record class DeleteMaterialCommand(int Id) : IRequest<Material>
    {

    }
}
