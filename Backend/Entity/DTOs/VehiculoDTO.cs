namespace Entity.DTOs
{
    public class VehiculoDTO
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public int Anio { get; set; }
        public bool Disponible { get; set; }
    }
}


