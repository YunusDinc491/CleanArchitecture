using CleanArchitecture.Application.Features.CarFeatures.Commands.Login;
using MediatR;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.CreateNewTokenByRefreshToken
{
    public sealed record CreateNewTokenByRefreshTokenCommand(

        string UserId,
        string RefreshToken
        ) : IRequest<LoginCommandResponse>;
   
}
