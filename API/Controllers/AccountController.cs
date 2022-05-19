using BusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Account;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _iAccountService;

        public AccountController(IAccountService iAccountService)
        {
            _iAccountService = iAccountService;
        }
        [AllowAnonymous]
        [HttpPost("Login")]
        public Task<PersonModel> Login(LoginModel loginModel)
        {
            return  _iAccountService.Login(loginModel);
        }
    }
}
