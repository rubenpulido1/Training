using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  // Route (base path)
  [Route("api/[controller]")] //localhost:5001/api/members
  [ApiController]

  // Injecting AppDbContext, any services registered in Program.cs are made available for dependency injection to other classes.
  public class MembersController(AppDbContext context) : ControllerBase
  {

    // Endpoints that allow us to return HTTP responses.
    [HttpGet]
    public ActionResult<IReadOnlyList<AppUser>> GetMembers()
    {
      List<AppUser> members = context.Users.ToList();
      return members;
    }

    // id here is a route parameter
    [HttpGet("{id}")] //localhost:5001/api/members/bob-id
    public ActionResult<AppUser> GetMember(string id)
    {
      // Find method fines an entity with the given primary key values.
      AppUser? member = context.Users.Find(id);

      if (member == null)
      {
        return NotFound();
      }

      return member;
    }
    
  }
}
