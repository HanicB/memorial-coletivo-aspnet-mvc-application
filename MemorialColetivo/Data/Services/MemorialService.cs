using MemorialColetivo.Models;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo.Data.Services
{
    public class MemorialService : IMemorialService
    {
        private readonly AppDbContext _context;
        public MemorialService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Memorial memorial)
        {
            await _context.Memorial.AddAsync(memorial);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Memorial>> GetAllAsync()
        {
            var result = await _context.Memorial.ToListAsync();
            return result;
        }

        public async Task<Memorial> GetByIdAsync(int id)
        {
            var result = await _context.Memorial.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Memorial Update(int id, Memorial newMemorial)
        {
            throw new NotImplementedException();
        }
    }
}
