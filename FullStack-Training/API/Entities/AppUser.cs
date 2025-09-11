
namespace API.Entities;

public class AppUser
{
  // NewGuide() is a static method from the System.Guid struct that generates a new Globally Unique Identifier (GUID).
  public string Id { get; set; } = Guid.NewGuid().ToString();

  public required string UserName { get; set; }
  
  public required string UserEmail { get; set;}
}
