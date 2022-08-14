using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Tamanho : IEntidade
    {
        public Tamanho(int id, string nome)
        {
            Id = id;
            Nome = nome;

            DataAlteracao = DataAlteracao;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; private set;  }
        public string Nome { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        //Relacionamento
        public List<Pizza> Pizzas { get; private set;  }

        public void AtualizarDados(string nome)
        {
            if (nome.Length < 1)
                return;

            Nome = nome;

            DataAlteracao = DateTime.Now;
        }
    }
}
