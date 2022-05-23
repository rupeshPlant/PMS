using Models.Account;
using Refit;

namespace UI.Services.Refit
{
    public interface IAccountService
    {
        [Post("/api/Account/Login")]
        Task<HttpResponseMessage> Login([Body] LoginModel loginModel);
        
        [Post("/api/Employee/EmployeeList")]
        Task<HttpResponseMessage> EmployeeList();
    }
}
