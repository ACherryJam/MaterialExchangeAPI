﻿using FluentValidation;
using MaterialExchangeAPI.Data.Repositories;
using MaterialExchangeAPI.DTO;

namespace MaterialExchangeAPI.Validators
{
    public class UpdateMaterialDTOValidator : AbstractValidator<UpdateMaterialDTO>
    {
        public UpdateMaterialDTOValidator(ISellerRepository repository) 
        {
            RuleFor(material => material.Name).NotEmpty();
            RuleFor(material => material.Price).GreaterThan(0);
            RuleFor(material => material.SellerId).Custom(
                (id, context) =>
                {
                    if (!repository.Exists(id))
                    {
                        context.AddFailure("SellerID must exist");
                    }
                }
            );
        }
    }
}
