using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace davaleba_10
{
    internal class Employ
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Country Country { get; set; }
        public Gender Gender { get; set; }
        public Contacts Contact { get; set; }

        public Employ(string name, string surname, DateTime dateOfBirth,
                      Country country, Gender gender, Contacts contact)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Country = country;
            Gender = gender;
            Contact = contact;
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {GetAge()}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Contact: {Contact}");
            Console.WriteLine("--------------------");
        }
    }
}
