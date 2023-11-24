using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaterialExchangeAPI.Controllers
{
    [ApiController]
    [Route("api/sellers")]
    public class SellerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SellerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetSellers()
        {
            List<Seller> sellers = await _mediator.Send(new GetSellersQuery());

            return Ok(sellers);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetSellerById(int id)
        {
            Seller seller = await _mediator.Send(new GetSellerByIdQuery(id));

            return seller == null ? NotFound() : Ok(seller);
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
