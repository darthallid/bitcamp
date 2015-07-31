using Shopping.DAL;
using Shopping.DAL.Entities;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace Shopping.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShoppingDbContext context = new ShoppingDbContext())
            {
                // We are setting up logging to Console
                context.Database.Log = Console.Write;

                // Uncomment line below to write to file
                /* context.Database.Log = WriteToFile; */

                // Below is commented out SQL Injection example
                /* string searchTerm = "Mostar'; DELETE FROM CITIES WHERE Name <> 'Test";
                string query = string.Format("SELECT * FROM CITIES WHERE Name='{0}'", searchTerm);
                List<City> cities = context.Database.SqlQuery<City>(query).ToList();
                Console.ReadLine(); */

                Console.WriteLine("Loading customer...");
                Customer customer = context.Customers
                    .Where(x => x.EmailAddress == "admir.tuzovic@outlook.com")
                    .Include(x => x.Profile) // Eager loading navigational property
                    .FirstOrDefault();
                Console.WriteLine("Loaded!");
                Console.ReadLine();
                Console.WriteLine("Accessing Profile data...");
                Console.WriteLine(customer.Profile.Address);
                Console.WriteLine("Accessed!");
                Console.ReadLine();

                Console.WriteLine("Mijenjamo property");
                customer.Profile.PhoneNumber = "3334444";
                Console.ReadLine();

                // Uncomment code below to add new customer
                /*City city1 = context.Cities.First();
                Customer customer1 = new Customer
                {
                    FirstName = "Admir",
                    LastName = "Tuzovic",
                    EmailAddress = "admir.tuzovic@outlook.com",
                    Profile = new CustomerProfile
                    {
                        City = city1,
                        Address = "Test 1",
                       PhoneNumber = "38761489976"
                    }
                };
                context.Customers.Add(customer1);*/

                Console.WriteLine("Saving changes...");
                context.SaveChanges();
                Console.WriteLine("Saved!");
                Console.ReadLine();

                Console.WriteLine("Preparing City Query...");
                IQueryable<City> query = context.Cities;
                query = query.Where(x => x.Name == "Mostar");
                Console.WriteLine("Prepared! Hit ENTER to Execute...");
                Console.ReadLine();

                Console.WriteLine("Executing City Query...");
                City city = query.SingleOrDefault();
                Console.WriteLine("Executed!");
                Console.ReadLine();
            }
        }

        static void WriteToFile(string input)
        {
            File.WriteAllText("C:\\BitCamp\\Log.TXT", input);
        }
    }
}
