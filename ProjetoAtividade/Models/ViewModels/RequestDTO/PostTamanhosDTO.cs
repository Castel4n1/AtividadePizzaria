using System.ComponentModel.DataAnnotations;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostTamanhosDTO
    {
        [Required(ErrorMessage = "Nome do Tamanho é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tamanho deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Nome { get; set; }
    }
}
