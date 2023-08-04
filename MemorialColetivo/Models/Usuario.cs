using System.ComponentModel.DataAnnotations;

namespace MemorialColetivo.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
