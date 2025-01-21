using EBS.Entity.Entities;
using EBS.WebUI.DTOs.EmployeeDtos;
using Microsoft.AspNetCore.Identity;

namespace EBS.WebUI.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<IdentityResult> CreateEmployeeAsync(EmployeeRegisterDto employeeRegister);
        Task<string> LoginAsync(EmployeeLoginDto employeeLogin);
        Task<bool> LogoutAsync();
        Task<bool> CreateRoleAsync(EmployeeRoleDto employeeRoleDto);
        Task<bool> AssignRoleAsync(List<AssignRoleDto> assignRoleDto);
    
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetByIdEmployeesAsync(int id);
    }
}
