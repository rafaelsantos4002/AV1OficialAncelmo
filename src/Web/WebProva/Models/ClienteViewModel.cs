using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProva.Models
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public string Cpf { get; set; }
        public bool Sexo { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
    }
}
