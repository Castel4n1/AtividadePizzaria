using ProjetoAtividade.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostPizzasDTO
    {
        [Required(ErrorMessage = "Nome da Pizza é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pizza deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Imagem obrigatória")]
        public string FotoUrl { get; set; }
        public decimal Preco { get; set; }

        [Display(Name = "Incluido")]
        [Required(ErrorMessage = "Encerramento é obrigatório!")]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Remoção")]
        [Required(ErrorMessage = "Encerramento é obrigatório!")]
        public DateTime DataRemocao { get; set; }

        #region relacionamento
        //[Display(Name = "Informe o Sabor")]
        //[Required(ErrorMessage = "Sabor é Obrigatório")]
        public List<int> SaboresId { get; set; }

        //[Display(Name = "Informe o Tamanho")]
        //[Required(ErrorMessage = "Sabor é Obrigatório")]
        public int TamanhoId { get; set; }
        #endregion
    }
}
