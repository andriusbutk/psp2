using E_Shop.Entity.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Shop.Entity.Models
{
    public class Specification
    {
        public int Id { get; set; }

        public int Storage { get; set; }
        public SystemType OSType { get; set; }

        public byte Camera { get; set; }

        public Product Product { get; set; }
    }
}
