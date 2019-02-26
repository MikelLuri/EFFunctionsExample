namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.MyContext context)
        {
            context.Persons.AddOrUpdate(h => h.Id, new Person { Id = 1, FirstName = "Pedro", LastName = "Perez" });
            context.Persons.AddOrUpdate(h => h.Id, new Person { Id = 2, FirstName = "Fernando", LastName = "Fernandez" });
        }
    }
}
