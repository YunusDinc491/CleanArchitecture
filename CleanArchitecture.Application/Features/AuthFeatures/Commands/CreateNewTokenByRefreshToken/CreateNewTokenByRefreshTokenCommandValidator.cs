using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.CreateNewTokenByRefreshToken
{
    public sealed class CreateNewTokenByRefreshTokenCommandValidator
 : AbstractValidator<CreateNewTokenByRefreshTokenCommand>
    {
        public CreateNewTokenByRefreshTokenCommandValidator()
        {
            RuleFor(P=> P.UserId).NotEmpty().WithMessage("User bilgisi boş olamaz!");
            RuleFor(P => P.UserId).NotNull().WithMessage("User bilgisi boş olamaz!");
            RuleFor(P => P.RefreshToken).NotNull().WithMessage("Refresh Token bilgisi boş olamaz!");

            RuleFor(P => P.RefreshToken).NotEmpty().WithMessage("Refresh token bilgisi boş olamaz!");
        }
    }
}
