using FluentValidation;
using MaterialExchangeAPI.DTO;

namespace MaterialExchangeAPI.Validators
{
    public class CreateMaterialDTOValidator : AbstractValidator<CreateMaterialDTO>
    {
        public CreateMaterialDTOValidator() 
        {
            RuleFor(material => material.Name).NotEmpty();
            RuleFor(material => material.Price).GreaterThan(0);
        }
    }
}
