# Connection strings and notes for Part 2

## If you are using SQL Server Express LocalDB on Windows

Connection string:

```text
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;
```

The full `Scaffold-DbContext` command is:

```powershell
Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models
```

## If you are using SQL Server in the dev container

Connection string:

```text
Data Source=localhost;Database=ContosoPizza;Integrated Security=false;User ID=sa;Password=P@ssw0rd;
```

## Scaffolding with `dotnet ef` 

To scaffold with `dotnet ef`, run:

```dotnet-cli
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef dbcontext scaffold "Connection String Here" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models
```

The other parameters you'll need are:

- `--data-annotations`
- `--namespace` (for model namespace)
- `--context-namespace` (for DbContext namespace)
