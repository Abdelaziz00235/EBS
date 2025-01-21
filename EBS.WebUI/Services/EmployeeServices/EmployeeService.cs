using EBS.Entity.Entities;
using EBS.WebUI.DTOs.EmployeeDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace EBS.WebUI.Services.EmployeeServices
{
    public class EmployeeService(UserManager<Employee> _userManager, SignInManager<Employee> _signInManager,RoleManager<EmployeeRole> _roleManager) : IEmployeeService
    {
        
        public async Task<bool> AssignRoleAsync(List<AssignRoleDto> assignRoleDto)
        {
            throw new NotImplementedException();
        }
          
        public async Task<IdentityResult> CreateEmployeeAsync(EmployeeRegisterDto employeeRegister)
        {
            var employee = new Employee
            {
                FullName = employeeRegister.FullName,
                PhoneNumber = employeeRegister.PhoneNumber,
                Email = employeeRegister.Email,
                NNI = employeeRegister.NNI,
                Matricule = employeeRegister.Matricule,
                Designation = employeeRegister.Designation,
                ImageUrl = employeeRegister.ImageUrl,
                AgenceId = employeeRegister.AgenceId,
                DepartmentId = employeeRegister.DepartmentId,
                IsActived = employeeRegister.IsActived,
                IsDeleted = employeeRegister.IsActived, 
                UserName = employeeRegister.UserName

            };
            if (employeeRegister.Password != employeeRegister.ConfirmPassword)
            {
                return new IdentityResult();
            }
            var result = await _userManager.CreateAsync(employee, employeeRegister.Password);
            if (result.Succeeded) 
            {
                await _userManager.AddToRoleAsync(employee,"Role1");
                return result;  
            }
            return result;
        }

        public Task<bool> CreateRoleAsync(EmployeeRoleDto employeeRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<Employee> GetByIdEmployeesAsync(int id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<string> LoginAsync(EmployeeLoginDto employeeLoginDto)
        {
           var user = await _userManager.FindByEmailAsync(employeeLoginDto.Email);
            if (user == null) 
            {
                return null;
            }
            var result = await _signInManager.PasswordSignInAsync(user, employeeLoginDto.Password,false,false);
            if (!result.Succeeded)
            {
                return null;
            }
            else
            { 
                var IsSuperAdmin = await _userManager.IsInRoleAsync(user, "SuperAdmin");
                if (IsSuperAdmin) { return "SuperAdmin"; }

                var IsAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                if (IsAdmin) { return "Admin"; }

                var IsMagasinier = await _userManager.IsInRoleAsync(user,"Magasinier");
                if(IsMagasinier) { return "Magasinier";}

                var IsAssistantLogistique = await _userManager.IsInRoleAsync(user,"AssistantLogistique");
                if(IsAssistantLogistique) { return "AssistantLogistique";}
                    
                var IsResponsableLogistique = await _userManager.IsInRoleAsync(user,"ResponsableLogistique");
                if(IsResponsableLogistique) { return "ResponsableLogistique";}

                var IsGestionnaire_de_stock = await _userManager.IsInRoleAsync(user,"Gestionnaire_de_stock");
                if(IsGestionnaire_de_stock) { return "Gestionnaire_de_stock";}

                var IsClient = await _userManager.IsInRoleAsync(user,"Client");
                if(IsClient) { return "Client";}

                var IsRole1 = await _userManager.IsInRoleAsync(user,"Role1");
                if(IsRole1) { return "Role1";}

                var IsRole2 = await _userManager.IsInRoleAsync(user,"Role2");
                if(IsRole2) { return "Role2";}
            }
            return "null";
        }

        public Task<bool> LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
