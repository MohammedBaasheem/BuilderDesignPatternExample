namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder builder = new ProductBuilder();
            Product product = builder
                .SetName("iPhone 15")
                .SetDescription("A cutting-edge smartphone")
                .SetPrice(999)
                .SetCategory("Smartphones")
                .SetManufacturer("Apple")
                .SetFeatures(new List<string> { "OLED Display", "A15 Bionic Chip", "Dual Camera" })
                .Build();

            Console.WriteLine(product);

            Product anotherProduct = new ProductBuilder()
                .SetName("Samsung Galaxy S25")
                .SetPrice(899)
                .SetCategory("Smartphones")
                .SetManufacturer("Samsung")
                .SetFeatures(new List<string> { "OLED Display", "Snapdragon  Chip", "Dual Camera" })
                .Build();

            Console.WriteLine("\n" + anotherProduct);

            Console.ReadKey();
        }
    }
}
