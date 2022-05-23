using BusinessLayer.Employee;
using Microsoft.AspNetCore.Mvc;
using Models.Account;

namespace API.Controllers;

public class EmployeeController : BaseApiController
{
    private readonly IEmployeeService _iEmployeeService;

    public EmployeeController(IEmployeeService iEmployeeService)
    {
        _iEmployeeService = iEmployeeService;
    }
    
    [HttpPost("EmployeeList")]
    public Task<List<EmployeeModel>> DisplayEmployee()
    {
        return  _iEmployeeService.DisplayEmployee();
    }
}