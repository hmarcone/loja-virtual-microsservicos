using System.Data.Entity.ModelConfiguration;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Mapping
{
    public class CategoryMapping : EntityTypeConfiguration<Category>, IMapping
    {
        public CategoryMapping()
        {
            ToTable("Categories");
            HasKey(c => c.CategoryId);
            Property(c => c.CategoryId);
            Property(c => c.Name).IsRequired().HasMaxLength(100);
            HasMany(p => p.Products).WithRequired(c => c.Category).HasForeignKey(p => p.CategoryId).WillCascadeOnDelete();
        }
    }
}
