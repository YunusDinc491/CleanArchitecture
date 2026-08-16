using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.RoleFeatures.Command.CreateRole
{
    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(P=> P.Name).NotEmpty().WithMessage("Role adı boş olamaz!");
            RuleFor(P => P.Name).NotNull().WithMessage("Role adı boş olamaz!");
        }
    }
}
