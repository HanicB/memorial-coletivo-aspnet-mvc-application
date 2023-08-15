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
        public void Add(Memorial memorial)
        {
            _context.Memorial.Add(memorial);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Memorial>> GetAll()
        {
            var result = await _context.Memorial.ToListAsync();
            return result;
        }

        public Memorial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Memorial Update(int id, Memorial newMemorial)
        {
            throw new NotImplementedException();
        }
    }
}
