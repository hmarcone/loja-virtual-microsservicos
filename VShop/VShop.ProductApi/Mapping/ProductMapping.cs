using System.Data.Entity.ModelConfiguration;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>, IMapping
    {
        public ProductMapping()
        {
            this.ToTable("Products");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id);
            this.Property(x => x.Name).IsRequired().HasMaxLength(100);
            this.Property(x => x.Description).IsRequired().HasMaxLength(255);
            this.Property(x => x.ImageURL).IsRequired().HasMaxLength(255);
            this.Property(x => x.Price).HasPrecision(12, 2);
            //this.HasMany(x => x.Category).WithOptional().HasForeignKey(y => y.CategoryId);
        }
    }
}
