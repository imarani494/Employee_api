using EmployeeAdmin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeAdmin.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee?> UpdateEmployee(int id, Employee employee); // Update Employee
        Task<bool> DeleteEmployee(int id); //  Delete Employee
    }
}

// open-close principle
