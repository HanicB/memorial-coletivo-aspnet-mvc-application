using System.ComponentModel.DataAnnotations;

namespace MemorialColetivo.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        [Display(Name = "Link da foto de perfil")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Nome completo")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relationships
        public List<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
