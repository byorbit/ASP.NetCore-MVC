using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("email bos olamaz!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Lütfen doğru email giriniz!");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("Lütfen product name'i bos geçmeyiniz");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lütfen product name i 100 karakterden fazla girmeyiniz");


        }
    }
}
