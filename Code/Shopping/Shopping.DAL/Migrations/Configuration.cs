namespace Shopping.DAL.Migrations
{
    using Shopping.DAL.Seeders;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingDbContext context)
        {
            context.SeedCities(new DefaultCitySeedBatch());
        }
    }
}
