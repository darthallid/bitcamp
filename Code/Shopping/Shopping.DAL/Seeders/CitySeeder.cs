using Shopping.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Shopping.DAL.Seeders
{
    public static class CitySeeder
    {
        public static void SeedCities(this ShoppingDbContext context, IEnumerable<City> cities)
        {
            foreach(City city in cities)
            {
                bool exists = context.Cities.Any(x => x.Name == city.Name);
                if(!exists)
                {
                    context.Cities.Add(city);
                }
            }
            context.SaveChanges();
        }
    }
}
