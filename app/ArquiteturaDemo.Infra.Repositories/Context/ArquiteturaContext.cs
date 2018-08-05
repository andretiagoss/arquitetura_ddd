using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Infra.Repositories.EF.EntitiesMap;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ArquiteturaContext : DbContext
    {
        public ArquiteturaContext()
            : base("DBArquiteturaDDD")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            //Definido conversões e propriedades que são geradas automaticamente 
            //pelo Migrations na criação da base de dados e tabelas.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //    .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<string>()
                .Where(p => p.Name.Contains("Description"))
                .Configure(p => p.HasMaxLength(400));

            //modelBuilder.Properties<string>()
            //    .Where(p => p.Name.Contains("UF"))
            //    .Configure(p => p.HasMaxLength(2));

            //Definindo para o contexto, a necessidade de se utilizar o que foi escrito nas classes de mapeamento (Map).
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreateDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
