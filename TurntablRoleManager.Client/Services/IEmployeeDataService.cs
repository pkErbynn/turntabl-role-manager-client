using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurntablRoleManager.Client.Model;

namespace TurntablRoleManager.Client.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<EmployeeDetailsModel>> GetAllEmployees();
        Task<EmployeeDetailsModel> GetEmployeeDetails(int employeeId);
        Task<EmployeeResponse> AddEmployee(EmployeeModel employee);
        Task UpdateEmployee(UpdateEmployeeModel employee);
        Task DeleteEmployee(int id);
    }
}