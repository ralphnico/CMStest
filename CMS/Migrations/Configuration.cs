namespace CMS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CMS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CMS.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CMS.Models.DataContext context)
        {
              //This method will be called after migrating to the latest version.

              //You can use the DbSet<T>.AddOrUpdate() helper extension method 
              //to avoid creating duplicate seed data. E.g.
            
            context.Users.AddOrUpdate(d => d.username,

               new User() { username = "admindavid", password = "test", firstname = "david", lastname = "king", role = "admin"}
              
               );

                 
                
            
        }
    }
}
