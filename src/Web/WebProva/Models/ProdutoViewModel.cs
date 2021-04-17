using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProva.Models
{
    public class ProdutoViewModel
    {
        public string Descricao { get; set; }
        public int CodigoDoProduto { get; set; }
        public decimal Preco { get; set; }
        public string TipoDePagamento { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Observação { get; set; }
        public string NomeDoCartao { get; set; }
        public int NumeroDoCartao { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public int VCC { get; set; }
    }
}
