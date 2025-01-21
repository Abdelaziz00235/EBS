using EBS.WebUI.DTOs.BasketDtos;
using FluentValidation;

namespace EBS.WebUI.Validators
{
    public class BasketValidator : AbstractValidator<CreateBasketDto>
    {
        public BasketValidator()
        {
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Vous devez commander au moins un produit :)");
        }
    }
}
