using Mapster;
using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
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

            List<GetMaterialDTO> response = materials.Adapt<List<GetMaterialDTO>>();
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetMaterialById(int id)
        {
            Material material = await _mediator.Send(new GetMaterialByIdQuery(id));
            if (material == null)
                return NotFound();

            GetMaterialDTO response = material.Adapt<GetMaterialDTO>();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> AddMaterial(CreateMaterialDTO dto)
        {
            CreateMaterialCommand command = dto.Adapt<CreateMaterialCommand>();

            Material material = await _mediator.Send(command);
            GetMaterialDTO response = material.Adapt<GetMaterialDTO>();

            return CreatedAtAction("GetMaterialById", new { id = response.Id }, response);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMaterial(int id, UpdateMaterialDTO dto)
        {
            UpdateMaterialCommand command = dto.Adapt<UpdateMaterialCommand>() with
            {
                Id = id
            };

            Material material = await _mediator.Send(command);
            if (material == null)
                return NotFound();

            GetMaterialDTO response = material.Adapt<GetMaterialDTO>();
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMaterial(int id)
        {
            Material material = await _mediator.Send(new DeleteMaterialCommand(id));

            return material == null ? NotFound() : Ok();
        }
    }
}
