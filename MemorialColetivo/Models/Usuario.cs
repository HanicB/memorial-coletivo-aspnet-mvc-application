using System.ComponentModel.DataAnnotations;

namespace MemorialColetivo.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
