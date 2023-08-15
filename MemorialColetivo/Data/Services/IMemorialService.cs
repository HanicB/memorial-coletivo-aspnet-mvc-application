using MemorialColetivo.Models;

namespace MemorialColetivo.Data.Services
{
    public interface IMemorialService
    {
        Task<IEnumerable<Memorial>> GetAll();
        Memorial GetById(int id);
        void Add(Memorial memorial);
        Memorial Update(int id, Memorial newMemorial);
        void Delete(int id);
    }
}
