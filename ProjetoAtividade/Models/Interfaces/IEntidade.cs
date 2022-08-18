using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models.Interfaces
{
    public interface IEntidade
    {
        int Id { get; }
        DateTime DataCadastro { get; }
        DateTime DataAlteracao { get; }
    }
}
