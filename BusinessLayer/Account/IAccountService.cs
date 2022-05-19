using Models;
using Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IAccountService
    {
        public Task<PersonModel> Login(LoginModel loginModel);
    }
}
