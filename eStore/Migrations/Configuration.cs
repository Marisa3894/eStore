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
                new Product {Image="/img/listItem/zafu102.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="jadegray/blue", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zafu202.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="blue/natural", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zafu302.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="paprika/putty", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zafu402.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="straw/natural", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zafu502.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="blue/putty", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zafu602.png", Name="zafu", Price=49.00m, Filling="buckwheat hulls", Fabric="multi", Color="straw/paprika", Description="traditional zafu with sewn-in strap for easy transport. &nbsp; size: 14 inch diameter x 4.5 inch adjustable height. &nbsp; weight: approx. 6 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube102.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="jadegray/blue", Description="unique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube202.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="blue/natural", Description="unique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube302.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="paprika/putty", Description="unique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube402.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="straw/natural", Description="unique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube502.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="blue/putty", Description="unique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/cube602.png", Name="cube", Price=69.00m, Filling="buckwheat hulls", Fabric="multi", Color="straw/paprika", Description="cunique cube design is uncommonly comfortable with sewn-in strap for easy transport. &nbsp; size: adjustable height 13 inch cube. &nbsp; weight: approx. 9 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab200.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="solid", Color="blue", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab212.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="print", Color="blue/putty", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab220.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="print", Color="blue/natural", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab300.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="solid", Color="paprika", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab336.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="print", Color="paprika/putty", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab400.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="solid", Color="straw", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zab410.png", Name="zabouton", Price=59.00m, Filling="cotton batting", Fabric="print", Color="straw/natural", Description="traditional 3 inch thick x 28 inch wide x 32 inch long zabouton mat.  weight: approx. 7lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini200.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="solid", Color="blue", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini200.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="solid", Color="blue", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini212.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="print", Color="blue/putty", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini212.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="print", Color="blue/putty", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini300.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="solid", Color="paprika", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini300.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="solid", Color="paprika", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini336.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="print", Color="paprika/putty", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini336.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="print", Color="paprika/putty", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini400.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="solid", Color="straw", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini400.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="solid", Color="straw", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini401.png", Name="mini zabouton", Price=29.00m, Filling="buckwheat hulls", Fabric="print", Color="straw/natural", Description="28 inch x 12 inch mini zab can be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
                new Product {Image="/img/listItem/zabmini401.png", Name="mini zabouton", Price=25.00m, Filling="cotton batting", Fabric="print", Color="straw/natural", Description="28 inch x 12 inch mini zab can be easily be folded or used flat to cushion feet, ankles, or prop other areas of the body.  weight: approx. 3 lbs.", InventoryDate=DateTime.Now},
        };
            context.Products.AddOrUpdate(p => new { p.Image, p.Name, p.Filling, p.Fabric, p.Color, p.Price, p.Description, p.InventoryDate }, products);
        }
    }
}
