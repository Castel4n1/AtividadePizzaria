using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class PizzaSabor
    {
        public PizzaSabor(int saborId, int pizzaId)
        {
            SaborId = saborId;
            PizzaId = pizzaId;
        }

        public int SaborId { get; private set; }
        public Sabor Sabor { get; set; }
        public int PizzaId { get; private set; }
        public Pizza Pizza { get; set; }
    }
}
