namespace ContosoPizza.Models;

/*
OrderDetails is a join class that facilitates a many-to-many relationship between Order and Product.
This design allows: one order to have many products and one product to appear in many order.
It also stores additional data about the relationship (Quantity).
*/
public class OrderDetail
{
  public int Id { get; set; }
  public int Quantity { get; set; }
  public int ProductId { get; set; }
  public int OrderId { get; set; }

  public Order Order { get; set; } = null!;
  public Product Product { get; set; } = null!;
}