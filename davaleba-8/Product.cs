using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_8
{
    internal class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public bool Nuts;
        public string Image;
        public bool Vegetarian;
        public int Spiciness;
        public string Category;

        public Product(int id, string name, double price, bool nuts, string image, bool vegetarian, int spiciness, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Nuts = nuts;
            Image = image;
            Vegetarian = vegetarian;
            Spiciness = spiciness;
            Category = category;
        }

        // პროდუქტის ინფორმაციის გამოტანა
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price} ₾");
            Console.WriteLine($"Contains Nuts: {Nuts}");
            Console.WriteLine($"Image: {Image}");
            Console.WriteLine($"Vegetarian: {Vegetarian}");
            Console.WriteLine($"Spiciness: {Spiciness}");
            Console.WriteLine($"Category: {Category}");
        }

        // ფასდაკლების დამატება
        public void ApplyDiscount(double percent)
        {
            Price -= Price * percent / 100;
        }

        // ცხარეობის შემოწმება
        public bool IsSpicy()
        {
            return Spiciness > 5;
        }

        // ვეგეტარიანულია თუ არა
        public bool IsVegetarian()
        {
            return Vegetarian;
        }
    }
}

