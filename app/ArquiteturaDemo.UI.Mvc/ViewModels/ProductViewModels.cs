using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ArquiteturaDemo.UI.Mvc.ViewModels
{
    public class ProductViewModels
    {
        [Key]
        public int ProductId { get; set; }

        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(200, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]       
        [DisplayName("Nome")]
        public string ProductName { get; set; }

        [MaxLength(300, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha o campo Preço")]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [DisplayName("Ativo?")]
        public bool IsActive { get; set; }

        public virtual CategoryViewModels Category { get; set; }
        
        [DisplayName("Categoria")]
        public IEnumerable<SelectListItem> ComboCategory { get; set; }
    }
}