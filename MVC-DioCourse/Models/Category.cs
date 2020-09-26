using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DioCourse.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Description { get; set; }

        public List<Product> Product { get; set; }
    }
}
