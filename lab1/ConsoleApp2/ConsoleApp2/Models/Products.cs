namespace ConsoleApp2.Models
{
    internal class Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Products(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public static List<Products> SortByPrice(List<Products> products)
        {
            products.Sort((x, y) => x.Price.CompareTo(y.Price));
            return products;
        }
    }
}
