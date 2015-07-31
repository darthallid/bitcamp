using Shopping.DAL.Entities;
using System.Collections.Generic;

namespace Shopping.DAL.Seeders
{
    public class DefaultCitySeedBatch : List<City>
    {
        public DefaultCitySeedBatch()
        {
            Add(new City { Name = "Sarajevo" });
            Add(new City { Name = "Banja Luka" });
            Add(new City { Name = "Mostar" });
        }
    }
}
