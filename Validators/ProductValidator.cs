using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace TaylorsPetStore.Validators
{
    internal class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(Product => Product.Name).NotNull().WithMessage("Please specify a name");
            RuleFor(Product => Product.Price).GreaterThan(0);
            RuleFor(Product => Product.Quantity).GreaterThan(0);
            RuleFor(Product => Product.Description).MinimumLength(10).When(Product => Product.Description.Length > 0);
        }
    }
}
