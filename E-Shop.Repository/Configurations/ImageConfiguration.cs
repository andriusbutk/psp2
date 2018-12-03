using E_Shop.Entity.Models;
using System.Data.Entity.ModelConfiguration;

namespace E_Shop.Repository.Configurations
{
    public class ImageConfiguration : EntityTypeConfiguration<Image>
    {
        public ImageConfiguration()
        {
            HasKey(x => x.Id);

            Property(c => c.Width)
                .IsRequired();

            Property(c => c.Length)
                .IsRequired();

        }
    }
}
