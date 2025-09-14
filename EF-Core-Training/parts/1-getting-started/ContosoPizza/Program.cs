using ContosoPizza.Data;
using ContosoPizza.Models;

// context is a DbContext and contains DbSet<T> properties
using ContosoPizzaContext context = new ContosoPizzaContext();

var veggieSpecial = context.Products
                       .Where(p => p.Name == "Veggie Special Pizza")
                       .FirstOrDefault();

if (veggieSpecial is Product)
{
  context.Remove(veggieSpecial);
}

context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (Product p in products)
{
  Console.WriteLine($"Id:    {p.Id}");
  Console.WriteLine($"Name:  {p.Name}");
  Console.WriteLine($"Price: {p.Price}");
  Console.WriteLine(new string('-', 20));
}