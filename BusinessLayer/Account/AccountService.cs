using Data;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models.Account;

namespace BusinessLayer
{
    public class AccountService : IAccountService
    {
        private readonly DataContext _context;
        private readonly ILogger _logger;


        public AccountService(DataContext context, IConfiguration config, ILogger<AccountService> logger)
        {
            _context = context;
            _logger = logger;
        }




        public async Task<PersonModel> Login(LoginModel loginModel)
        {
            try
            {

                var person = (from e in _context.Employee
                              join p in _context.Person on e.PersonId equals p.PersonId
                              where loginModel.UserName == e.UserName
                              select p).SingleOrDefault();

                var employe = await _context.Employee.Where(x => x.UserName == loginModel.UserName).SingleOrDefaultAsync();
                if (employe != null)
                {
                    var passwordVerificationResult = new PasswordHasher<Employee>().VerifyHashedPassword(employe, employe.PasswordHash, loginModel.Password);

                    switch (passwordVerificationResult)
                    {
                        case PasswordVerificationResult.Failed:
                            _logger.LogWarning("Authentication inccorect for Username: {UserName} Time: {Time}", loginModel.UserName, DateTimeOffset.UtcNow);
                            return new PersonModel
                            {
                                Name = "Invalid Password",
                                PersonId = null
                            };

                        case PasswordVerificationResult.Success:
                            var result = new PersonModel
                            {
                                Name = person.Name,
                                PersonId = person.PersonId
                            };
                            return result;

                        default:
                            _logger.LogWarning("BadRequest: Something went wrong when authenticating. UserName: {UserName} Time: {Time}", loginModel.UserName, DateTimeOffset.UtcNow);
                            return new PersonModel
                            {
                                Name = "Invalid User",
                                PersonId = null
                            };
                    }
                }
                else return new PersonModel
                {
                    Name = "Invalid User",
                    PersonId = null
                };


            }
            catch (Exception)
            {
                 return new PersonModel
                {
                    Name = "Invalid User",
                    PersonId = null
                };
                _logger.LogWarning("BadRequest: Something went wrong when authenticating. UserName: {UserName} Time: {Time}", loginModel.UserName, DateTimeOffset.UtcNow);
                throw;
            }
        }
    }
}
