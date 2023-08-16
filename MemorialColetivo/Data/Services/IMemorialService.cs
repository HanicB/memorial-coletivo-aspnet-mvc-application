using MemorialColetivo.Models;

namespace MemorialColetivo.Data.Services
{
    public interface IMemorialService
    {
        Task<IEnumerable<Memorial>> GetAllAsync();
        Task<Memorial> GetByIdAsync(int id);
        Task AddAsync(Memorial memorial);
        Memorial Update(int id, Memorial newMemorial);
        void Delete(int id);
    }
}
