namespace API.Models
{
    public class Veiculos
    {
        public long IdVeiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Ano { get; set; }
        public int Placa { get; set; }
        public string? Cor { get; set; }
    }
}
