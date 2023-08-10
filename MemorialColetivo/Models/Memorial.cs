using System.ComponentModel.DataAnnotations;

namespace MemorialColetivo.Models
{
    public class Memorial
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Historia { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataFalecimento { get; set; }
        public string Formacao { get; set; }
        public string Religiao { get; set; }
        public string Hobbies { get; set; }
        public string MemorialPictureURL { get; set; }

        //Relationships
        public List<Usuario_Memorial> Usuario_Memorial { get; set; }
    }
}
