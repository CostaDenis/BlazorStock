using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStock.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo é obrigatório")]
        [MaxLength(50, ErrorMessage = "O título deve ter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "O título deve ter no mínimo 5 caracteres")]
        public string Title { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}