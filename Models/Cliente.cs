using System.Runtime.ConstrainedExecution;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string datanascimento { get; set; }
        public string genero { get; set; }
    }
}
