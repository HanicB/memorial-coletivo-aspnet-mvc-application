using MemorialColetivo.Models;
using Microsoft.EntityFrameworkCore;

namespace MemorialColetivo.Data.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly AppDbContext _context;
        public UsuariosService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> getAll()
        {
            var result = await _context.Usuario.ToListAsync();
            return result;
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Update(int id, Usuario newUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
