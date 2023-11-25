using FluentValidation;
using MaterialExchangeAPI.DTO;

namespace MaterialExchangeAPI.Validators
{
    public class UpdateMaterialDTOValidator : AbstractValidator<UpdateMaterialDTO>
    {
        public UpdateMaterialDTOValidator() 
        {
            RuleFor(material => material.Name).NotEmpty();
            RuleFor(material => material.Price).GreaterThan(0);
        }
    }
}
