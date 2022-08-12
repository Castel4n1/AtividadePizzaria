using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Pizza : IEntidade
    {
        public Pizza(int id, string nome, string fotoUrl, decimal preco, int tamanhoId )
        {
            Id = id;
            Nome = nome;
            FotoUrl = fotoUrl;
            Preco = preco;
            TamanhoId = tamanhoId;

            DataAlteracao = DataAlteracao;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string FotoUrl { get; private set; }
        public decimal Preco { get; private set; }
        public int TamanhoId { get; private set; }
        public Tamanho Tamanho { get; set; }

        public DateTime DataAlteracao { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public List<PizzaSabor> PizzaSabores { get; set; }
        
        public void AtualizarDados(string nome, string fotoUrl, decimal novoPreco)
        {
            if (nome.Length < 1 || novoPreco < 0)
                return;

            Nome = nome;
            FotoUrl = fotoUrl;
            Preco = novoPreco;
        }
    }
}
