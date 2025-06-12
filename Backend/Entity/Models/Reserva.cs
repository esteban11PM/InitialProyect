namespace Entity.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public bool Activo { get; set; } = true;


        // Relaciones
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}


