using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DioCourse.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Range(1, 10, ErrorMessage = "Valor fora da faixa.")]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        // To make a relationship between Product and Category.
        public Category Category { get; set; }
    }
}
