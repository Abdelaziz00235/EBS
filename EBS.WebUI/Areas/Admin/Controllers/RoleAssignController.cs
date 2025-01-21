using EBS.Entity.Entities;
using EBS.WebUI.DTOs.EmployeeDtos;
using EBS.WebUI.Services.EmployeeServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleAssignController(IEmployeeService _employeeService, UserManager<Employee> _userManager, RoleManager<EmployeeRole> _roleManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _employeeService.GetAllEmployeesAsync();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = await _employeeService.GetByIdEmployeesAsync(id);
            TempData["user_Id"] = user.Id;

            var roles = await _roleManager.Roles.ToListAsync();
            var userRoles = await _userManager.GetRolesAsync(user);

            List<AssignRoleDto> AssignRoleList = new List<AssignRoleDto>();

            foreach (var role in roles)
            {
                var assignRole = new AssignRoleDto();
                assignRole.Id = role.Id;
                assignRole.RoleName = role.Name;
                assignRole.RoleExist = userRoles.Contains(role.Name);

                AssignRoleList.Add(assignRole);
            }

            return View(AssignRoleList);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleDto> assignRoleList)
        {
            int userId = (int) TempData["user_Id"];

            var user = await _employeeService.GetByIdEmployeesAsync(userId);

            foreach (var item in assignRoleList) 
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }  
            }
            return RedirectToAction("Index");
        }
    }
}