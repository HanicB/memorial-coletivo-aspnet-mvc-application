using MemorialColetivo.Models;

namespace MemorialColetivo.Data.Services
{
    public interface IUsuariosService
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> GetById(int id);
        void Add(Usuario usuario);
        Usuario Update(int id, Usuario newUsuario);
        void Delete(int id);
    }
}
