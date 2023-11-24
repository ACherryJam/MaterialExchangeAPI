using MaterialExchangeAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MaterialExchangeAPI.Controllers
{
    [ApiController]
    [Route("api/sellers")]
    public class SellerController : ControllerBase
    {
        public SellerController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> GetSellers()
        {
            throw new NotImplementedException();
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetSellerById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> AddSeller(CreateSellerDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateSeller(int id, UpdateSellerDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteSeller(int id)
        {
            throw new NotImplementedException();
        }
    }
}
