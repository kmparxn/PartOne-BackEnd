namespace EldenLabs.Models
{
    public class Ruta
    {
        public int Id { get; set; }
        public string TipoVehiculo { get; set; }
        public string LugarOrigen { get; set; }
        public DateTime DepartureDate { get; set; }
        public string HoraSalida { get; set; }
        public int CuposDisponibles { get; set; }
        public string LugarDestino { get; set; }
    }
}
