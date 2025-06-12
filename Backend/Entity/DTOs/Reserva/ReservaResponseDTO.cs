namespace Entity.DTOs.Reserva
{
    public class ReservaResponseDTO
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = null!;

        public string NombreCliente { get; set; } = string.Empty;
        public string VehiculoPlaca { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;
    }
}


