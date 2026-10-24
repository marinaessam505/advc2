namespace advc2
{
    #region task1
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, string category, decimal price, int stock)
        {
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }
    }

    class Program
    {
        
        static List<Product> SearchProducts(
            List<Product> products,
            Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (Product p in products)
            {
                if (filter(p))
                {
                    result.Add(p);
                }
            }

            return result;
        }

        static void PrintProducts(List<Product> products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine(
                    $"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }
        }

        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product("Laptop", "Electronics", 1200, 10),
            new Product("Phone", "Electronics", 800, 25),
            new Product("Headphones", "Electronics", 150, 40),
            new Product("T-Shirt", "Clothing", 30, 100),
            new Product("Jeans", "Clothing", 60, 50),
            new Product("Chocolate", "Food", 5, 200),
            new Product("Coffee Beans", "Food", 15, 80),
            new Product("Novel", "Books", 20, 60)
        };

            
            Console.WriteLine("--- Electronics ---");
            PrintProducts(SearchProducts(
                products, p => p.Category == "Electronics"));

            
            Console.WriteLine("\n--- Under $50 ---");
            PrintProducts(SearchProducts(
                products, p => p.Price < 50));

            
            Console.WriteLine("\n--- In Stock ---");
            PrintProducts(SearchProducts(
                products, p => p.Stock > 0));

            
            Console.WriteLine("\n--- Clothing Under $100 ---");
            PrintProducts(SearchProducts(
                products,
                p => p.Category == "Clothing" && p.Price < 100));
        }


    #endregion




    }















}
