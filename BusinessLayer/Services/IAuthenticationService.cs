using Models.Account;
using Models.AuthServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public interface IAuthenticationService
    {
        Task<ApiResponse<AuthServerLoginResponse>> AuthenticateUserAsync(LoginModel loginModel);
        Task<ApiResponse<AuthServerUserProfileResponse>> GetUserDetailsAsync(string token);

    }
}
