using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data;

/*

  DBContext is the primary class responsible for interacting with the database. It does several things:
    - Manages the database connection
    - Tracks changes to objects
    - Handles querying and saving data
    - Provides access to DbSet properties (which represent tables)

  DbSet<T> is also a class that represents a table in the database and allows you to perform CRUD operations.
  
*/
public class ContosoPizzaContext : DbContext
{
  public DbSet<Customer> Customers { get; set; } = null!;
  public DbSet<Order> Orders { get; set; } = null!;
  public DbSet<Product> Products { get; set; } = null!;
  public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    /*
      Hard coding a connection string like this is bad practice. 
      Always use a secure storage method for real world connections strings.
    */
    optionsBuilder.UseSqlServer(@"data source=DBSINTWEBDEV;initial catalog=ContosoPizza-Part1;trusted_connection=true");
  }
}