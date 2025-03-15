using EmployeeAdmin.Models;
using EmployeeAdmin.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeAdmin.Controllers
{ //dip
//di
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            return Ok(await _employeeService.AddEmployee(employee));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            var updatedEmployee = await _employeeService.UpdateEmployee(id, employee);
            if (updatedEmployee == null)
                return NotFound("Employee not found.");
            
            return Ok(updatedEmployee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var isDeleted = await _employeeService.DeleteEmployee(id);
            if (!isDeleted)
                return NotFound("Employee not found.");

            return Ok("Employee deleted successfully.");
        }
    }
}
