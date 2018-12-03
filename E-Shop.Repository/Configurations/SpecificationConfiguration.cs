using E_Shop.Entity.Models;
using System.Data.Entity.ModelConfiguration;

namespace E_Shop.Repository.Configurations
{
    public class SpecificationConfiguration : EntityTypeConfiguration<Specification>
    {
        public SpecificationConfiguration()
        {
            HasKey(m => m.Id);

            Property(c => c.Camera)
                .IsRequired();

            Property(c => c.Storage)
                .IsRequired();

            Property(c => c.OSType)
                .IsRequired();

        }
    }
}
