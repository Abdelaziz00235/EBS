using AutoMapper;
using EBS.Entity.Entities;
using EBS.WebUI.DTOs.RoleDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EBS.WebUI.Services.RoleServices
{
    public class RoleService(RoleManager<EmployeeRole> _roleManager,IMapper _mapper) : IRoleService
    {
        public async Task CreateRoleAsync(CreateRoleDto createRoleDto)
        {
            var role = _mapper.Map<EmployeeRole>(createRoleDto);
            await _roleManager.CreateAsync(role);
        }

        public async Task DeleteRoleAsync(int id)
        {
            var  Value = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            await _roleManager.DeleteAsync(Value);
        }

        public async Task<List<ResultRoleDto>> GetAllRolesAsync()
        {
            var values = await _roleManager.Roles.ToListAsync();

            return _mapper.Map<List<ResultRoleDto>>(values);
        }

        public async Task<UpdateRoleDto> GetByIdRoleAsync(int id)
        {
            var Value = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            
            return   _mapper.Map<UpdateRoleDto>(Value);

        }

        public async Task<UpdateRoleDto> UpdateRoleAsync(UpdateRoleDto updateRoleDto)
        {
            var _role = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == updateRoleDto.Id);

            if (_role.Id == updateRoleDto.Id)
            {
                _role.Name = updateRoleDto.Name;
            }
            return _mapper.Map<UpdateRoleDto>(_role);
        }
    }
}
