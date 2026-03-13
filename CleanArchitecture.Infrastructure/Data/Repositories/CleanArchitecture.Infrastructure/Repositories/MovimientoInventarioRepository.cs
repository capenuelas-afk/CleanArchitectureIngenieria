using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class MovimientoInventarioRepository : IMovimientoInventarioRepository
    {
        private readonly ApplicationDbContext _context;

        public MovimientoInventarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MovimientoInventario>> GetAllAsync()
        {
            return await _context.MovimientosInventario.ToListAsync();
        }

        public async Task<MovimientoInventario?> GetByIdAsync(int id)
        {
            return await _context.MovimientosInventario.FindAsync(id);
        }

        public async Task AddAsync(MovimientoInventario movimiento)
        {
            await _context.MovimientosInventario.AddAsync(movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MovimientoInventario movimiento)
        {
            _context.MovimientosInventario.Update(movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var movimiento = await _context.MovimientosInventario.FindAsync(id);
            if (movimiento != null)
            {
                _context.MovimientosInventario.Remove(movimiento);
                await _context.SaveChangesAsync();
            }
        }
    }
}
