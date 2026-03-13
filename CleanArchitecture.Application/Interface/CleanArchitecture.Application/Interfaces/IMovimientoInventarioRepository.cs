using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IMovimientoInventarioRepository
    {
        Task<IEnumerable<MovimientoInventario>> GetAllAsync();
        Task<MovimientoInventario?> GetByIdAsync(int id);
        Task AddAsync(MovimientoInventario movimiento);
        Task UpdateAsync(MovimientoInventario movimiento);
        Task DeleteAsync(int id);
    }
}
