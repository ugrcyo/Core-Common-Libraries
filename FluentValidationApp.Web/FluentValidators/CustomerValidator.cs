using FluentValidation;
using FluentValidationApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz!";
        public CustomerValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(a => a.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Geçerli bir E-Mail adresi giriniz!");
            RuleFor(a => a.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Age alanı 18-60 arasında olmalıdır!");
            RuleFor(a => a.Birthday).NotEmpty().WithMessage(NotEmptyMessage).Must(a =>
            {
                return DateTime.Now.AddYears(-18) >= a;
            }).WithMessage("Yaşınız 18'den büyük olmalıdır!");

            RuleFor(a => a.Gender).IsInEnum().WithMessage("{PropertyName} alanı Erkek için 1, Kadın için 2 olmalıdır.");

            RuleForEach(a => a.Addresses).SetValidator(new AddressValidator());
        }
    }
}
