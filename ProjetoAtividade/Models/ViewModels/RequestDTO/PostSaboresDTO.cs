﻿using System.ComponentModel.DataAnnotations;

namespace ProjetoAtividade.Models.ViewModels.RequestDTO
{
    public class PostSaboresDTO
    {
        [Required(ErrorMessage = "Nome do Sabor é Obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Sabor deve ter no máximo 50 caracters, e no mínimo 3")]
        public string Nome { get; set; }

        public string FotoUrl { get; set; }
        public decimal Preco { get; set; }

    }
}
