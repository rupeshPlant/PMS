using Models.Account;

namespace BusinessLayer.Employee;

public interface IEmployeeService
{
    Task<List<EmployeeModel>> DisplayEmployee();
}