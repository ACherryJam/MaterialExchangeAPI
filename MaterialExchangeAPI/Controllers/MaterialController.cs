using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaterialExchangeAPI.Controllers
{
    [ApiController]
    [Route("api/materials")]
    public class MaterialController : ControllerBase
    {
        public MaterialController()
        {
            
        }

        [HttpGet]
        public async Task<ActionResult> GetMaterials()
        {
            throw new NotImplementedException();
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetMaterialById(int id)
        {
            throw new NotImplementedException();
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
