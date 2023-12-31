﻿using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Mapster;
using MaterialExchangeAPI.DTO;
using MaterialExchangeAPI.Extensions;
using MaterialExchangeAPI.Models;
using MaterialExchangeAPI.Requests.Commands;
using MaterialExchangeAPI.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using ValidationResult = FluentValidation.Results.ValidationResult;

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

        /// <summary>
        /// Получение списка материалов
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<GetMaterialDTO>>> GetMaterials()
        {
            List<Material> materials = await _mediator.Send(new GetMaterialsQuery());

            List<GetMaterialDTO> response = materials.Adapt<List<GetMaterialDTO>>();
            return Ok(response);
        }

        /// <summary>
        /// Получение материала по ID
        /// </summary>
        /// <param name="id">ID материала</param>
        [HttpGet("id")]
        public async Task<ActionResult<GetMaterialDTO>> GetMaterialById(int id)
        {
            Material material = await _mediator.Send(new GetMaterialByIdQuery(id));
            if (material == null)
                return NotFound();

            GetMaterialDTO response = material.Adapt<GetMaterialDTO>();
            return Ok(response);
        }

        /// <summary>
        /// Создание материала
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<GetMaterialDTO>> AddMaterial(
            CreateMaterialDTO dto,
            IValidator<CreateMaterialDTO> validator
        )
        {
            // Validation
            ValidationResult result = await validator.ValidateAsync(dto);

            if (!result.IsValid)
                return ValidationProblem(result.ToModelStateDictionary());

            // Request handling
            CreateMaterialCommand command = dto.Adapt<CreateMaterialCommand>();

            Material material = await _mediator.Send(command);
            GetMaterialDTO response = material.Adapt<GetMaterialDTO>();

            return CreatedAtAction("GetMaterialById", new { id = response.Id }, response);
        }

        /// <summary>
        /// Изменение материала по ID
        /// </summary>
        /// <param name="id">ID материала</param>
        [HttpPut]
        public async Task<ActionResult<GetMaterialDTO>> UpdateMaterial(
            [Required] int id,
            UpdateMaterialDTO dto,
            IValidator<UpdateMaterialDTO> validator
        )
        {
            // Validation
            ValidationResult result = await validator.ValidateAsync(dto);

            if (!result.IsValid)
                return ValidationProblem(result.ToModelStateDictionary());

            // Request handling
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

        /// <summary>
        /// Удаление материала по ID
        /// </summary>
        /// <param name="id">ID материала</param>
        [HttpDelete]
        public async Task<ActionResult> DeleteMaterial([Required] int id)
        {
            Material material = await _mediator.Send(new DeleteMaterialCommand(id));

            return material == null ? NotFound() : Ok();
        }
    }
}
