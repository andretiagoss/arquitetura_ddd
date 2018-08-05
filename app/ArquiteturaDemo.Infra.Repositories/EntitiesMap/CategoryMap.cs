using ArquiteturaDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaDemo.Infra.Repositories.EF.EntitiesMap
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(t => t.CategoryId);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(100);

            this.ToTable("Category", "dbo");
        }
    }
}
