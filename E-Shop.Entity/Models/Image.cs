namespace E_Shop.Entity.Models
{
    public class Image
    {
        public int Id { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public Image() { }

        public Image(int length, int width)
        {
            Length = length;
            Width = width;
        }

        /*public Product Product { get; set; }*/
    }
}
