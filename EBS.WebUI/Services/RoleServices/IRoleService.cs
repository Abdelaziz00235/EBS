using EBS.WebUI.DTOs.RoleDtos;

namespace EBS.WebUI.Services.RoleServices
{
    public interface IRoleService
    {
        Task<List<ResultRoleDto>> GetAllRolesAsync();
        Task<UpdateRoleDto> GetByIdRoleAsync(int id);
        Task CreateRoleAsync(CreateRoleDto createRoleDto);
        Task<UpdateRoleDto> UpdateRoleAsync(UpdateRoleDto updateRoleDto);
        Task DeleteRoleAsync(int id);
    }
}
