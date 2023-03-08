## Project Commands
```csharp
dotnet new sln -o Store
dotnet new --list
dotnet new web -f net6.0 --output StoreApp
dotnet sln .\Store\ add .\Store\StoreApp\
dotnet sln .\Store list
```

## Package Management
```csharp
dotnet add package <packagename> --version 6.0.0
dotnet add Microsoft.EntityFramework.Core --version 6.0.0
dotnet add Microsoft.EntityFramework.Core.Sqlite --version 6.0.0
dotnet add Microsoft.EntityFramework.Core.Design --version 6.0.0
dotnet list package
```

## dotnet Tool
```csharp
dotnet tool list
dotnet tool list -g
```

## Migrations
```csharp
dotnet ef migrations add <name>
dotnet ef database update
```

```sqlite
.help
.show
.system cls
.system dir
.mode list
.mode box
SELECT * FROM Products;
```