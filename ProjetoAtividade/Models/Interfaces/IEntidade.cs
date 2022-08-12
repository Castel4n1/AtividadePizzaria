using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models.Interfaces
{
    public class IEntidade
    {
        int id { get; }
        DateTime DataCadastro { get; }
        DateTime DataAlteração { get; }
    }
}
