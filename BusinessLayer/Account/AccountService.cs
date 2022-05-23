using Data;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models;
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
                    var passwordVerificationResult = new PasswordHasher<Entities.Employee>().VerifyHashedPassword(employe, employe.PasswordHash, loginModel.Password);

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
                                Email = employe.Email,
                                UserName = employe.UserName,
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

        public async Task<ResponseMessageModel> CreateEmploye(CreateEmployeeModel employeeModel)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var checkIfUserExistes = _context.Employee.Any(x => x.Email == employeeModel.EmailAddress || x.UserName.ToLower() == employeeModel.UserName.ToLower());
                if (checkIfUserExistes) return new ResponseMessageModel() { ResponseMessage = "Employee Already Exists" };

                var person = new Person
                {
                    Name = employeeModel.Name
                };
                await _context.Person.AddAsync(person);
                await _context.SaveChangesAsync();

                await _context.Employee.AddAsync(new Entities.Employee
                {
                    Email = employeeModel.EmailAddress,
                    PersonId = person.PersonId,
                    PhoneNumber = employeeModel.PhoneNumber,
                    RoleId = "needToChange:D",
                    UserName = employeeModel.UserName,
                    InsertDate = DateTimeOffset.UtcNow,
                    InsertPersonId = "1",
                    UpdateDate = DateTimeOffset.UtcNow,
                    UpdatePersonId = "1"
                });
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return new ResponseMessageModel()
                {
                    ResponseMessage = "Employee Created Successfully"
                };
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
                   
        }

    }
}
