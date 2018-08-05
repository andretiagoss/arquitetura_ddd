using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArquiteturaDemo.UI.Mvc.ViewModels
{
    public class CategoryViewModels
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Categoria")]
        public string CategoryName { get; set; }

        [DisplayName("Ativo?")]
        public bool IsActive { get; set; }

        public virtual ICollection<ProductViewModels> Products { get; set; }
    }
}