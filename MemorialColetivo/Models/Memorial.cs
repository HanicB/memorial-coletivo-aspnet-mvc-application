using System.ComponentModel.DataAnnotations;

namespace MemorialColetivo.Models
{
    public class Memorial
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Historia do falecido")]
        public string Historia { get; set; }
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Data de Falecimento")]
        public DateTime DataFalecimento { get; set; }
        [Display(Name = "Formacao")]
        public string Formacao { get; set; }
        [Display(Name = "Religião")]
        public string Religiao { get; set; }
        [Display(Name = "Hobbies")]
        public string Hobbies { get; set; }
        [Display(Name = "MemorialPictureURL")]
        public string MemorialPictureURL { get; set; }
        

        //Relationships
        public List<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
