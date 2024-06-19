namespace API.Models
{
    public class Cliente
    {
        public long IdCliente { get; set; }
        public string? Nome { get; set; }
        public int CPF { get; set; }
        public string? Endereco { get; set;}
        public string? Telefone { get; set; }
        public string? Email { get; set;}
    }
}
