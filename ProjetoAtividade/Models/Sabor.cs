using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Sabor : IEntidade
    {
        public Sabor(string nome, string fotoUrl)
        {
            Nome = nome;
            FotoUrl = fotoUrl;

            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
        }

        public int Id { get; set; }
        public string Nome { get;  set; }
        public string FotoUrl { get;  set; }

        public List<PizzaSabor> PizzaSabores { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public void AtualizarDados(string nome, string fotoUrl)
        {
            if (nome.Length < 1)
                return;

            Nome = nome;
            FotoUrl = fotoUrl;

        }

    }
}
