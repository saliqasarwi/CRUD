using CRUD.Data;
using CRUD.Models;
namespace CRUD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            //Insert Data
            Order o1 = new Order() { Address = "Jenin", createdAt = new DateTime() };
            Order o2 = new Order() { Address = "Nablus", createdAt = new DateTime() };
            Order o3 = new Order() { Address="Ramallah",createdAt = new DateTime() };
            Order o4 = new Order() { Address="Tulkarm",createdAt=new DateTime() };
            Order o5 = new Order() { Address = "Tubas", createdAt = new DateTime() };
            context.Orders.Add(o1);
            context.Orders.Add(o2);
            context.Orders.Add(o3);
            context.Orders.Add(o4);
            context.Orders.Add(o5);
            Product p1=new Product() { Name="bag",Price=125};
            Product p2 = new Product() { Name = "scarf", Price = 25 };
            Product p3 = new Product() { Name = "watch", Price = 99 };
            Product p4 = new Product() { Name = "necklace", Price = 350 };
            Product p5 = new Product() { Name = "shoes", Price = 236 };
            context.Products.Add(p1);
            context.Products.Add(p2);
            context.Products.Add(p3);
            context.Products.Add(p4);
            context.Products.Add(p5);
            context.SaveChanges();
            //get all products
            Console.WriteLine("All Products:");
            var products=context.Products.ToList();
            foreach(var p in products)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("=======================");
            //get all orders
            Console.WriteLine("All Orders:");
            var orders = context.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine(order.Address);
            }
            Console.WriteLine("=======================");
            //update product name
            var product =context.Products.First(p=>p.Name=="scarf");
            product.Name = "book";
            context.SaveChanges();
            //update order createdAt
            var o=context.Orders.First(o=>o.createdAt==DateTime.MinValue);
            o.createdAt = DateTime.Now;
            context.SaveChanges();
            /*
                remove product with id 2
                remove order with id 3*/
            var pp = context.Products.First(pro => pro.ProdId == 2);
            context.Products.Remove(pp);
            var oo=context.Orders.First(or=>or.OrdId==3);
            context.Orders.Remove(oo);
            context.SaveChanges();
        }

    }


}
