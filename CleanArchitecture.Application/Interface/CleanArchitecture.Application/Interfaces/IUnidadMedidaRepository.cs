using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IUnidadMedidaRepository
    {
        Task<IEnumerable<UnidadMedida>> GetAllAsync();
        Task<UnidadMedida?> GetByIdAsync(int id);
        Task AddAsync(UnidadMedida unidad);
        Task UpdateAsync(UnidadMedida unidad);
        Task DeleteAsync(int id);
    }
}
