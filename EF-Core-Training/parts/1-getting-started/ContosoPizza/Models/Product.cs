using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

/*
  Specifies how the Price property should be mapped to a column in the database.
  We're using Data Annotations to define Price as a decimal with two points of precision (6 total digits).
*/
  [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
}