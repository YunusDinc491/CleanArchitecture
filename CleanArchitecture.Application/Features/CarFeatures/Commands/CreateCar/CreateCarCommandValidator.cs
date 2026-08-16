using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>

    {
        public CreateCarCommandValidator()
        {
            RuleFor(p=> p.Name).NotEmpty().WithMessage("Araç Adı Boş Olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Araç Adı Boş Olamaz!");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Araç Adı Boş Olamaz!");


            RuleFor(p => p.Model).NotEmpty().WithMessage("Araç Modeli Boş Olamaz!");
            RuleFor(p => p.Model).NotNull().WithMessage("Araç Modeli Boş Olamaz!");
            RuleFor(p => p.Model).MinimumLength(3).WithMessage("Araç Modeli Boş Olamaz!");

            RuleFor(p => p.EnginePower).NotEmpty().WithMessage("Araç Motor Gücü Boş Olamaz!");
            RuleFor(p => p.EnginePower).NotNull().WithMessage("Araç Motor Gücü Boş Olamaz!");
            RuleFor(p => p.EnginePower).GreaterThan(0).WithMessage("Araç Motor Gücü 0'dan büyük olmalıdır!");
        }
    }
}
