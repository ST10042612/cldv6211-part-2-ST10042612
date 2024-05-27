using KhumaloCraft_Part2.Data;
using KhumaloCraft_Part2.Models;
using System.Diagnostics;
using System.IO.Pipelines;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductsDBContext context)
        {
            // Look for any students.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var product = new Product[]
            {
                new Product{ProductName="Cat Statue",Category="Stone",Price=20, Availability=100},
                new Product{ProductName="Scrap Metal Artpiece",Category="Metal",Price=50, Availability=100},
                new Product{ProductName="Chair",Category="Wood",Price=100, Availability=100}

            };

            context.Products.AddRange(product);
            context.SaveChanges();

            var user = new User[]
            {
                new User{FirstName = "Sam", Surname = "Smith", Username = "User1", Password = "123"},
                new User{FirstName = "Dude", Surname = "Mann", Username = "User2", Password = "1234"},
                new User{FirstName = "Garry", Surname = "Guy", Username = "User3", Password = "12345"}
            };


            context.Users.AddRange(user);
            context.SaveChanges();

            var seller = new Seller[]
           {
                new Seller{SellerName="Hal", SellerSurname="9000", Username="Seller1", Password = "123"},
                new Seller{SellerName="Jordan", SellerSurname="Diaz", Username="Seller2", Password = "1234"}
           };

            context.Sellers.AddRange(seller);
            context.SaveChanges();

            var order = new Order[]
            {
                new Order{UserIdentification=1, SellerIdentification=1, ProductIdentification=1}
            };

            context.Orders.AddRange(order);
            context.SaveChanges();


           
        }
    }
}