using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(p => p.Email).NotEmpty().WithMessage("Mail bilgisi boş olamaz!");
            RuleFor(p => p.Email).NotNull().WithMessage("Mail bilgisi boş olamaz!");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz!");

            RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullanıcı adı bilgisi boş olamaz!");
            RuleFor(p => p.UserName).NotNull().WithMessage("Kullanıcı adı bilgisi boş olamaz!");
            RuleFor(p => p.UserName).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalıdır!");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).NotNull().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir!");

        }

    }
}
