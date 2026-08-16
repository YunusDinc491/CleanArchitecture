using CleanArchitecture.Application.Features.AuthFeatures.Commands.CreateNewTokenByRefreshToken;
using CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;
using CleanArchitecture.Application.Features.CarFeatures.Commands.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IAuthService
    {
        Task RegisterAsync(RegisterCommand request);
        Task<LoginCommandResponse> LoginAsync(LoginCommand request, CancellationToken cancellationToken);
        Task<LoginCommandResponse> CreateTokenByRefresjTokenAsync ( CreateNewTokenByRefreshTokenCommand request,CancellationToken cancellationToken);
    }
}
