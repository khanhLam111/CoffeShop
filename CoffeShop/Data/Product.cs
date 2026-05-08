namespace coffeeshop.Data
{
    public class Product
    {
        public bool IsTrendingProduct { get; internal set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public decimal Price { get; internal set; }
        public string ImageUrl { get; internal set; }
    }
}