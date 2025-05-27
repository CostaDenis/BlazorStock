using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStock.Models
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Id é obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preço é obrigatório")]
        [DataType(DataType.Currency)]
        [Range(0.01, 9999.99, ErrorMessage = "O preço deve estar entre 0,01 e 9999,99")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória")]
        [Range(1, 9999, ErrorMessage = "A categoria deve ser um número entre 1 e 9999")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
    }
}