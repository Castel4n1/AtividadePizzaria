using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Pizza : IEntidade
    {

        public Pizza(string nome, decimal preco, string fotoUrl, int tamanhoId)
        {
            Nome = nome;
            Preco = preco;
            FotoUrl = fotoUrl;
            TamanhoId = tamanhoId;

            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
           
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string FotoUrl { get; private set; }
        public decimal Preco { get; private set; }

        //Relacionamentos
        public int TamanhoId { get; set; }
        public Tamanho Tamanho { get; set; }

        public DateTime DataAlteracao { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public List<PizzaSabor> PizzaSabores { get; set; }
        //Fecha_relacionamentos
        public void AtualizarDados(string nome, string fotoUrl, decimal novoPreco, int tamanhoId)
        {
            if (nome.Length < 1 || novoPreco < 0)
                return;

            Nome = nome;
            FotoUrl = fotoUrl;
            Preco = novoPreco;
            TamanhoId = tamanhoId;

            DataAlteracao = DateTime.Now;
        }
    }
}
