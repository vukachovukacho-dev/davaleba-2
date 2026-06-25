namespace davaleba_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(
           1,
           "Burger",
           15.99,
           false,
           "burger.jpg",
           false,
           7,
           "Fast Food"
       );

            product.ShowInfo();

            product.ApplyDiscount(10);

            Console.WriteLine("After Discount:");
            product.ShowInfo();

            Console.WriteLine($"Is Spicy: {product.IsSpicy()}");
        }
    }
}

