namespace ClassTask25.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<ProductCategory> ProdCat{ get; set; }
        public List<ProductImg> ProdImg{ get; set; }

    }
}
