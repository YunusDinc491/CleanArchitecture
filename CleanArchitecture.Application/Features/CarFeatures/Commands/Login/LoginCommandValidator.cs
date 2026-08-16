using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.UserNameOrEmail).NotEmpty().WithMessage("Kullanıcı adı ya da Mail bilgisi boş olamaz!");
            RuleFor(p => p.UserNameOrEmail).NotNull().WithMessage("Kullanıcı adı ya da Mail bilgisi boş olamaz!");
            RuleFor(p => p.UserNameOrEmail).MinimumLength(3).WithMessage("Kullanıcı adı ya da Mail en az 3 karakter olmalıdır!");

            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).NotNull().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir!");
        }
    }
}
