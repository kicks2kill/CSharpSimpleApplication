namespace MVCProjectAttempt1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDbEntity : DbContext
    {
        public ProductDbEntity()
            : base("name=ProductDbEntity")
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Cost)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
