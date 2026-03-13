using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IExistenciaRepository
    {
        Task<IEnumerable<Existencia>> GetAllAsync();
        Task<Existencia?> GetByIdAsync(int id);
        Task AddAsync(Existencia existencia);
        Task UpdateAsync(Existencia existencia);
        Task DeleteAsync(int id);
    }
}
