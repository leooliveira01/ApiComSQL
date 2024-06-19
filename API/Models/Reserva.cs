namespace API.Models
{
    public class Reserva
    {
        public long Id { get; set; }
        public string? DataInicio { get; set; }
        public string? DataTermino { get; set; }
        public double Valor {  get; set; }

    }
}
