using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models.Account;

namespace BusinessLayer.Employee;

public class EmployeeService : IEmployeeService
{
    private readonly DataContext _context;
    private readonly ILogger _logger;


    public EmployeeService(DataContext context, IConfiguration config, ILogger<AccountService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<EmployeeModel>> DisplayEmployee()
    {
        try
        {
            var employeeData = await (from e in _context.Employee
                join p in _context.Person on e.PersonId equals p.PersonId
                join r in _context.Role on e.RoleId equals r.RoleId
                select new EmployeeModel
                {
                    EmployeeId = e.EmployeeId,
                    Name = p.Name,
                    UserName = e.UserName,
                    EmailAddress = e.Email,
                    PhoneNumber = e.PhoneNumber,
                    RoleName = r.RoleName
                }).ToListAsync();
                return employeeData;
            // else return new EmployeeModel
            // {
            //     Name = "Invalid User",
            //     EmployeeId = null
            // };
        }
        catch (Exception)
        {
            return null;
            // return new EmployeeModel
            // {
            //     Name = "Invalid User",
            //     EmployeeId = null
            // };
            _logger.LogWarning(
                "BadRequest: Something went wrong when authenticating. UserName: {UserName} Time: {Time}");
            throw;
        }
    }
}