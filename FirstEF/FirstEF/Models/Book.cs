using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstEF.Models
{
    
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Range(0,10000)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}