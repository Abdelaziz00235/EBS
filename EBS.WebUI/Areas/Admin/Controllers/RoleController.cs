using EBS.Entity.Entities;
using EBS.WebUI.DTOs.RoleDtos;
using EBS.WebUI.Helpers;
using EBS.WebUI.Services.RoleServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EBS.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class RoleController(IRoleService _roleService) : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            var values = await _roleService.GetAllRolesAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDto createRoleDto)
        {
            await _roleService.CreateRoleAsync(createRoleDto);
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateRoleDto>($"AspNetRoles/{id}");
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto updateRoleDto)
        {
            await _roleService.UpdateRoleAsync(updateRoleDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            await _roleService.DeleteRoleAsync(id);
            return RedirectToAction(nameof(Index));
        }

        
         public async Task<IActionResult> DetailsRole(int id)
         {  
            var value = await _roleService.GetByIdRoleAsync(id);
            return View(value);
         }


    }
}
