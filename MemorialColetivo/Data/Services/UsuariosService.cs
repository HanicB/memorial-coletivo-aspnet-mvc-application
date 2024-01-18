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
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            var result = await _context.Usuario.ToListAsync();
            return result;
        }

        public async Task<Usuario> GetById(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            return usuario;
        }


        // Implemente o método no UsuariosService.cs
        public Usuario Update(int id, Usuario newUsuario)
        {
            var existingUsuario = _context.Usuario.Find(id);

            if (existingUsuario != null)
            {
                existingUsuario.ProfilePictureURL = newUsuario.ProfilePictureURL;
                existingUsuario.FullName = newUsuario.FullName;
                existingUsuario.Bio = newUsuario.Bio;

                _context.SaveChanges();
            }

            return existingUsuario;
        }
        public void Delete(int id)
        {
            var usuario = _context.Usuario.Find(id);

            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
