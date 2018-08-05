using ArquiteturaDemo.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ArquiteturaDemo.Infra.Repositories.EF.EntitiesMap
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.HasKey(t => t.ProductId);

            //Definição de regras e criação de index para o campo ProductName
            this.Property(x => x.ProductName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnAnnotation(
                IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_ProductName", 1) { IsUnique = true }));
            
            this.Property(x => x.Description)                
                .HasMaxLength(300);
                        
            this.Property(x => x.Price)
                .IsRequired()
                .HasPrecision(10, 2);

            this.Property(t => t.CreateDate)
                .HasColumnType("datetime2");

            //Criação da FK entre a tabela Product e Category
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId);

            this.ToTable("Product", "dbo");

        }
    }
}
