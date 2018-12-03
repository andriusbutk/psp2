using E_Shop.Entity.Models;
using System.Data.Entity.ModelConfiguration;

namespace E_Shop.Repository.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Price)
                .IsRequired();

        }
    }
}
