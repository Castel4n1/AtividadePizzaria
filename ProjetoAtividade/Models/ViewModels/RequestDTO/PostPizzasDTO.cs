using System.ComponentModel.DataAnnotations;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostPizzasDTO
    {
        [Required(ErrorMessage = "Nome da Pizza é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pizza deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Imagem obrigatória")]
        public string FotoUrl { get; set; }
        public decimal Preco { get; set; }
    }
}
