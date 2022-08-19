using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Tamanho : IEntidade
    {
        public Tamanho(string nome)
        {
            Nome = nome;

            DataAlteracao = DateTime.Now;
            DataCadastro = DateTime.Now;
        }

        public int Id { get;  set;  }
        public string Nome { get;  set; }

        public DateTime DataAlteracao { get;  set; }
        public DateTime DataCadastro { get;  set; }
        //Relacionamento
        public List<Pizza> Pizzas { get; set;  }

        public void AtualizarDados(string nome)
        {
            if (nome.Length < 1)
                return;

            Nome = nome;

            DataAlteracao = DateTime.Now;
        }
    }
}
