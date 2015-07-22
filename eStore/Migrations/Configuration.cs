namespace eStore.Migrations
{
    using eStore.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using System.Security.Claims;
    using System;

    internal sealed class Configuration : DbMigrationsConfiguration<eStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eStore.Models.ApplicationDbContext context)
        {
            var user1 = new ApplicationUser
            {
                UserName = "marisa.reilly@outlook.com",
                Email = "marisa.reilly@outlook.com",
                FirstName = "Marisa",
                LastName = "Reilly",
            };

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            if (userManager.FindByName(user1.UserName) == null)
            {
                userManager.Create(user1, "Secret123!");
                userManager.AddClaim(user1.Id, new Claim("Admin", "true"));
            }

            var user2 = new ApplicationUser
            {
                UserName = "stephanie@snpc.com",
                Email = "stephanie@snpc.com",
                FirstName = "Stephanie",
                LastName = "Safran",
            };

            if (userManager.FindByName(user2.UserName) == null)
            {
                userManager.Create(user2, "Secret123!");
                userManager.AddClaim(user2.Id, new Claim("Reseller", "true"));
            }

            var products = new Product[] {
                new Product {Image="http://www.stillsitting.com/library/images/coverZafu.jpg", Name="Zafu", Price=49.00m, Filling="buckwheat", Fabric="print", Description="Zafu product description ...", InventoryDate=DateTime.Now},
                new Product {Image="http://d17dfdys9mu8rp.cloudfront.net/large/4f55190e3af9a.jpg", Name="Mini-Zab", Price=19.00m, Filling="cotton", Fabric="print", Description="Mini-Zab product description...", InventoryDate=DateTime.Now},
                new Product {Image="https://www.pillowcompany.com/images/pillows/zabuton-zoom.jpg", Name="Zabouton", Price=59.00m, Filling="cotton", Fabric="solid", Description="Zabouton product description...", InventoryDate=DateTime.Now},
                new Product {Image="http://www.secondnaturepillow.com/images/albums/NewAlbum_28ac1/tn_1200_NRwLaabel.jpg.jpg", Name="Neck Pillow", Price=29.00m, Filling="buckwheat", Fabric="solid", Description="Neck Pillow product description...", InventoryDate=DateTime.Now}
        };
            context.Products.AddOrUpdate(p => new { p.Image, p.Name, p.Filling, p.Fabric, p.Price, p.Description, p.InventoryDate }, products);
        }
    }
}
