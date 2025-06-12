namespace Entity.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }

}