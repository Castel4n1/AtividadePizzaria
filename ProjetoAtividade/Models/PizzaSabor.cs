using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAtividade.Models
{
    public class PizzaSabor
    {
        public PizzaSabor(int pizzaId, int saborId)
        {
            SaborId = saborId;
            PizzaId = pizzaId;
        }
        public Pizza Pizza { get; set; }
        public int PizzaId { get; set; }
        public Sabor Sabor { get; set; }
        public int SaborId { get; set; }
    }
}
