using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class Sabor : IEntidade
    {
        public Sabor(string nome)
        {
            Nome = nome;
        }

        public Sabor(int saborId, string nome, string fotoUrl)
        {
            SaborId = saborId;
            Nome = nome;
            FotoUrl = fotoUrl;

            DataAlteracao = DataAlteracao;
            DataCadastro = DateTime.Now;
        }
        public int SaborId { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string FotoUrl { get; private set; }
        public DateTime DataAlteracao { get; private set; }        
        public DateTime DataCadastro { get; private set; }

        public List<PizzaSabor> PizzaSabores { get; private set; }

        public void AtualizarDados(string nome, string fotoUrl, decimal novoPreco)
        {
            if (nome.Length < 1 || novoPreco < 0)
                return;

            Nome = nome;
            FotoUrl = fotoUrl;
            Preco = novoPreco;

            DataAlteracao = DateTime.Now;
        }

    }
}
