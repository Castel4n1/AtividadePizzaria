using System.ComponentModel.DataAnnotations;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostSaboresDTO
    {
        [Required(ErrorMessage = "Nome da Pizza é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pizza deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Sabor { get; set; }
    }
}
