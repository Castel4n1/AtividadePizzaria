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


            DataAlteracao = DataAlteracao;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nome { get; private set; }
        public string FotoUrl { get; private set; }
        public DateTime DataAlteracao { get; private set; }        
        public DateTime DataCadastro { get; private set; }

        public List<PizzaSabor> PizzaSabores { get; set; }

        public void AtualizarDados(string nome, string fotoUrl)
        {
            if (nome.Length < 1)
                return;

            Nome = nome;
            FotoUrl = fotoUrl;

            DataAlteracao = DateTime.Now;
        }

    }
}
