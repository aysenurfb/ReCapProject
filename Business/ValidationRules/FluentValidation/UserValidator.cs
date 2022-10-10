
using Core.Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("isim boş olamaz");
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("isim tek harf olamaz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("soyisim boş olamaz");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("soyisim tek harf olamaz");
        }
    }
}
