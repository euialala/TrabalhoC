using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal preco { get; set; }
        public int Estoque { get; set; }
        public string validade { get; set; }
        public string fabricacao { get; set; }
        public string categoria { get; set; }
        public string marca { get; set; }
        public string unidade { get; set; }
        public string descricao { get; set; }
    }
}
