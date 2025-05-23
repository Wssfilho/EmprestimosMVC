﻿using System.ComponentModel.DataAnnotations;

namespace LivrosEmprestimos.Models
{
    public class EmprestimosModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do recebedor")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage ="Digite o nome do Fornecedor")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome o nome do livro")]
        public string LivroEmprestado { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;


    }
}
