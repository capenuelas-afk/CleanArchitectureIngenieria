using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class UnidadMedidaRepository : IUnidadMedidaRepository
    {
        private readonly ApplicationDbContext _context;

        public UnidadMedidaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UnidadMedida>> GetAllAsync()
        {
            return await _context.UnidadesMedida.ToListAsync();
        }

        public async Task<UnidadMedida?> GetByIdAsync(int id)
        {
            return await _context.UnidadesMedida.FindAsync(id);
        }

        public async Task AddAsync(UnidadMedida unidad)
        {
            await _context.UnidadesMedida.AddAsync(unidad);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UnidadMedida unidad)
        {
            _context.UnidadesMedida.Update(unidad);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var unidad = await _context.UnidadesMedida.FindAsync(id);
            if (unidad != null)
            {
                _context.UnidadesMedida.Remove(unidad);
                await _context.SaveChangesAsync();
            }
        }
    }
}
