using E_Shop.Entity.Models;
using System.Data.Entity.ModelConfiguration;

namespace E_Shop.Repository.Configurations
{
    public class ManufacturerConfiguration : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
