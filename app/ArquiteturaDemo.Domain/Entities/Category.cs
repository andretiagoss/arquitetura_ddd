using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArquiteturaDemo.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        /// <summary>
        /// Return true if category is active
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool ActiveCategory(Category category)
        {
            return category.IsActive;
        }
    }
}
