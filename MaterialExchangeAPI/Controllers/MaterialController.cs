using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaterialExchangeAPI.Controllers
{
    [ApiController]
    [Route("api/materials")]
    public class MaterialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MaterialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetMaterials()
        {
            List<Material> materials = await _mediator.Send(new GetMaterialsQuery());

            return Ok(materials);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetMaterialById(int id)
        {
            Material material = await _mediator.Send(new GetMaterialByIdQuery(id));

            return material == null ? NotFound() : Ok(material);
        }

        [HttpPost]
        public async Task<ActionResult> AddMaterial(CreateMaterialDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMaterial(int id, UpdateMaterialDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMaterial(int id)
        {
            throw new NotImplementedException();
        }
    }
}
