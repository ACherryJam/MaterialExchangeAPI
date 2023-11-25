﻿using FluentValidation;
using FluentValidation.Results;
using Mapster;
using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Extensions;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
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

            List<GetSellerDTO> response = sellers.Adapt<List<GetSellerDTO>>();
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetSellerById(int id)
        {
            Seller seller = await _mediator.Send(new GetSellerByIdQuery(id));
            if (seller == null)
                return NotFound();

            GetSellerDTO response = seller.Adapt<GetSellerDTO>();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> AddSeller(CreateSellerDTO dto,
                                                  IValidator<CreateSellerDTO> validator)
        {
            // Validation
            ValidationResult result = await validator.ValidateAsync(dto);

            if (!result.IsValid)
                return ValidationProblem(result.ToModelStateDictionary());

            // Request handling
            CreateSellerCommand command = dto.Adapt<CreateSellerCommand>();

            Seller seller = await _mediator.Send(command);
            GetSellerDTO response = seller.Adapt<GetSellerDTO>();

            return CreatedAtAction("GetSellerById", new { id = response.Id }, response);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateSeller(int id, UpdateSellerDTO dto,
                                                     IValidator<UpdateSellerDTO> validator)
        {
            // Validation
            ValidationResult result = await validator.ValidateAsync(dto);

            if (!result.IsValid)
                return ValidationProblem(result.ToModelStateDictionary());

            // Request handling
            UpdateSellerCommand command = dto.Adapt<UpdateSellerCommand>() with
            {
                Id = id
            };

            Seller seller = await _mediator.Send(command);
            if (seller == null)
                return NotFound();

            GetSellerDTO response = seller.Adapt<GetSellerDTO>();
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteSeller(int id)
        {
            Seller seller = await _mediator.Send(new DeleteSellerCommand(id));

            return seller == null ? NotFound() : Ok();
        }
    }
}
