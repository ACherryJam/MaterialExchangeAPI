using FluentValidation;
using MaterialExchangeAPI.DTO;

namespace MaterialExchangeAPI.Validators
{
    public class UpdateSellerDTOValidator : AbstractValidator<UpdateSellerDTO>
    {
        public UpdateSellerDTOValidator()
        {
            RuleFor(seller => seller.Name).NotEmpty();
        }
    }
}
