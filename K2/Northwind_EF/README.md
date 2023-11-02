# Docker SQL server connection string Entity Framwork dbcontext scaffold

[Scaffolding (Reverse Engineering)](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)

[Entity Framework Core tools reference - .NET Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

**Install**

- `dotnet tool install --global dotnet-ef`

**NuGet packages**

- `dotnet add package Microsoft EntityFrameworkCore`
- `dotnet add package Microsoft EntityFrameworkCore.SqlServer`
- `dotnet add package Microsoft.EntityFrameworkCore.Tools`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`

**Entity Framwork dbcontext scaffold**

- `dotnet ef dbcontext scaffold "Server=localhost,1433;Database=northwind;User Id=sa;Password=Admin123;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context-dir Data --context NorthwindContext`
