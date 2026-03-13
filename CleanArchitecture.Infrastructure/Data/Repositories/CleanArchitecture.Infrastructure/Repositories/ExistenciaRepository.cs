using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class ExistenciaRepository : IExistenciaRepository
    {
        private readonly ApplicationDbContext _context;

        public ExistenciaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Existencia>> GetAllAsync()
        {
            return await _context.Existencias.ToListAsync();
        }

        public async Task<Existencia?> GetByIdAsync(int id)
        {
            return await _context.Existencias.FindAsync(id);
        }

        public async Task AddAsync(Existencia existencia)
        {
            await _context.Existencias.AddAsync(existencia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Existencia existencia)
        {
            _context.Existencias.Update(existencia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existencia = await _context.Existencias.FindAsync(id);
            if (existencia != null)
            {
                _context.Existencias.Remove(existencia);
                await _context.SaveChangesAsync();
            }
        }
    }
}
