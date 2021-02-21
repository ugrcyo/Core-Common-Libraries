using FluentValidation;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.FluentValidators
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz!";

        public AddressValidator()
        {
            RuleFor(a => a.Content).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(a => a.Province).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(a => a.PostCode).NotEmpty().WithMessage(NotEmptyMessage).MaximumLength(5).WithMessage("{PropertyName} alanı en fazla {MaxLength} karakter olmalıdır!");
        }
    }
}
