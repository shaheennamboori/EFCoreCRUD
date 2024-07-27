using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Converters
{
    internal static class EmployeeConverter
    {
        public static Employee ToEmployee(this AddEmployeeDto addEmployeeDto)
        {
            return new Employee
            {
                Email = addEmployeeDto.Email,
                Name = addEmployeeDto.Name,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };
        }
    }
}
