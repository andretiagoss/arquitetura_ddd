using System;
using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public virtual Category Category { get; set; }
                
        /// <summary>
        /// Return true if product is active and has been registered for more than 1 year
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool OldProduct(Product product)
        {
            return product.IsActive && DateTime.Now.Year - product.CreateDate.Year > 1;
        }

        /// <summary>
        /// Return true if product is active
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool ActiveProduct(Product product)
        {
            return product.IsActive;
        }
    }
}
