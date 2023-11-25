using FluentValidation;
using MaterialExchangeAPI.DTO;

namespace MaterialExchangeAPI.Validators
{
    public class CreateSellerDTOValidator : AbstractValidator<CreateSellerDTO>
    {
        public CreateSellerDTOValidator() 
        {
            RuleFor(seller => seller.Name).NotEmpty();
        }
    }
}
