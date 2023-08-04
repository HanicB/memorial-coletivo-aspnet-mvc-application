namespace MemorialColetivo.Models
{
    public class Usuario_Memorial
    {
        public int MemorialId { get; set; }
        public Memorial Memorial { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}
    }
}
