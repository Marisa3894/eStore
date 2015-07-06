namespace eStore.Migrations
{
    using eStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eStore.Models.ApplicationDbContext context)
        {
            var products = new Product[] {
                new Product {Image="http://www.stillsitting.com/library/images/coverZafu.jpg", Name="Zafu", Price=49.00m, Filling="buckwheat", Fabric="print", Description="Zafu product description ..."},
                new Product {Image="http://d17dfdys9mu8rp.cloudfront.net/large/4f55190e3af9a.jpg", Name="Mini-Zab", Price=19.00m, Filling="cotton", Fabric="print", Description="Mini-Zab product description..."},
                new Product {Image="https://www.pillowcompany.com/images/pillows/zabuton-zoom.jpg", Name="Zabouton", Price=59.00m, Filling="cotton", Fabric="solid", Description="Zabouton product description..."},
                new Product {Image="http://www.secondnaturepillow.com/images/albums/NewAlbum_28ac1/tn_1200_NRwLaabel.jpg.jpg", Name="Neck Pillow", Price=29.00m, Filling="buckwheat", Fabric="solid", Description="Neck Pillow product description..."}
        };
            context.Products.AddOrUpdate(p => new { p.Image, p.Name, p.Filling, p.Fabric, p.Price, p.Description }, products);
        }
    }
}
