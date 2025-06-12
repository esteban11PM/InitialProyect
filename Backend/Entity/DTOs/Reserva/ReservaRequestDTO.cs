namespace Entity.DTOs.Reserva
{
    public class ReservaRequestDto
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public bool Activo { get; set; } = true;

    }
}
