namespace ClassTask25.Models
{
    public class ProductImg
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
