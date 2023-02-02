using CarParts.API.Core.ViewModels;

namespace CarParts.API.Core.Interfaces
{
    public interface IPartService
    {
        Task<PartDto> GetByIdAsync(int id);

        List<PartDto> GetAllAsync();

        Task<PartDto> CreateAsync(PartDto partDto);

        Task UpdateAsync(int id,PartDto partDto);

        Task DeleteAsync(int id);
    }
}
