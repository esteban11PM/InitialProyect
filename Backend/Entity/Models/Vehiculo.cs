namespace Entity.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public int Anio { get; set; }
        public bool Disponible { get; set; }
        public bool Activo { get; set; } = true;

        // Relaciones
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }

}
