using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registers CORS services in the dependency injection container, enabling CORS support in the app.
builder.Services.AddCors();

var app = builder.Build();

/*
  Code below configures the HTTP request pipeline.
*/

// Adds the CORS middleware to the request pipeline and injects the CORS service to handle CORS for incoming requests.
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod()
  .WithOrigins("http://localhost:4200", "https://localhost:4200"));

// Maps HTTP requests to controller action methods based on route attributes.
app.MapControllers();

app.Run();
