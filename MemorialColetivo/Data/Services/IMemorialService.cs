using MemorialColetivo.Models;

namespace MemorialColetivo.Data.Services
{
    public interface IMemorialService
    {
        Task<IEnumerable<Memorial>> GetAllAsync();
        Task<Memorial> GetByIdAsync(int id);
        Task AddAsync(Memorial memorial);
        Task<Memorial> UpdateAsync(int id, Memorial newMemorial);
        Task DeleteAsync(int id);
    }
}
