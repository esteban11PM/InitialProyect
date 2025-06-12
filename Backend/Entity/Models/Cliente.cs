namespace Entity.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;


        // relaciones
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}



