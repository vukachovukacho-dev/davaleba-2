namespace davaleba_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(
           1,
           "Pizza",
           25,
           false,
           "pizza.jpg",
           false,
           7,
           "Food"
       );

            product.DisplayInfo();

            product.ApplyDiscount(20);

            Console.WriteLine("discounts:");

            product.DisplayInfo();
        }
    }
}

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public bool Nuts;
    public string Image;
    public bool Vegeterian;
    public int Spiciness;
    public string Category;

    public Product(int id, string name, double price, bool nuts,
                   string image, bool vegeterian,
                   int spiciness, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Nuts = nuts;
        Image = image;
        Vegeterian = vegeterian;
        Spiciness = spiciness;
        Category = category;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Category: {Category}");
    }

    public void ChangePrice(double newPrice)
    {
        Price = newPrice;
    }

    public void ApplyDiscount(double percent)
    {
        Price -= Price * percent / 100;
    }
}
