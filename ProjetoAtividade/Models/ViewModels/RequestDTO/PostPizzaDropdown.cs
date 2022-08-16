using System.Collections.Generic;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostPizzaDropdown
    {
        public PostPizzaDropdown()
        {
            Sabores = new List<Sabor>();
            Tamanhos = new List<Tamanho>();
        }

        public List<Sabor> Sabores { get; set; }
        public List<Tamanho> Tamanhos { get; set; }


    }
}
