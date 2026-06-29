namespace davaleba_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] employs = new Employ[8];

            employs[0] = new Employ("Luka", "Beridze",
                new DateTime(2000, 5, 10),
                Country.Georgia, Gender.Male, Contacts.Phone);

            employs[1] = new Employ("Nika", "Gelashvili",
                new DateTime(1998, 3, 15),
                Country.Georgia, Gender.Male, Contacts.Email);

            employs[2] = new Employ("John", "Smith",
                new DateTime(1995, 7, 20),
                Country.USA, Gender.Male, Contacts.Phone);

            employs[3] = new Employ("Emma", "Brown",
                new DateTime(1997, 11, 5),
                Country.USA, Gender.Female, Contacts.Fax);

            employs[4] = new Employ("Hans", "Muller",
                new DateTime(1990, 1, 25),
                Country.Germany, Gender.Male, Contacts.Email);

            employs[5] = new Employ("Anna", "Schmidt",
                new DateTime(1992, 9, 12),
                Country.Germany, Gender.Female, Contacts.Phone);

            employs[6] = new Employ("Pierre", "Martin",
                new DateTime(1993, 6, 30),
                Country.France, Gender.Male, Contacts.Fax);

            employs[7] = new Employ("Sophie", "Dubois",
                new DateTime(1996, 4, 18),
                Country.France, Gender.Female, Contacts.Email);

            Console.WriteLine("Employees from Georgia:");
            
            Helper.PrintByCountry(employs, Country.Georgia);
        }
    }
}
