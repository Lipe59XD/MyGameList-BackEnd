# MyGameList Backend

REST API for **MyGameList**, a web application for managing a personal video game collection.

Built with C# and ASP.NET Core, using Entity Framework Core and PostgreSQL for data persistence.

> 🚧 This project is currently under development.

## Tech Stack

- **C#**
- **.NET 10**
- **ASP.NET Core**
- **Entity Framework Core**
- **PostgreSQL**
- **Npgsql**
- **OpenAPI**

## Architecture

The backend is organized into separate folders to promote separation of concerns and maintainability.

```text
MyGameList-BackEnd/
├── Controllers/
├── Data/
├── Migrations/
├── Models/
├── Properties/
├── Services/
├── MyGameListAPI.csproj
└── Program.cs
```

### Project Structure

| Directory | Purpose |
|---|---|
| `Controllers/` | HTTP endpoints and request handling |
| `Services/` | Application logic |
| `Data/` | Database context and data configuration |
| `Models/` | Data structures and entities |
| `Migrations/` | Database schema versioning |
| `Program.cs` | Application setup and HTTP pipeline |

## Database

The application uses PostgreSQL as its relational database.

Entity Framework Core is used for database access, with Npgsql as the PostgreSQL provider.

The database context is configured through the `DefaultConnection` connection string.

## Configuration

The application reads the database connection string from configuration.

For local development, User Secrets can be used to store credentials outside the source code.

Example:

```bash
dotnet user-secrets init
```

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=MyGameList;Username=postgres;Password=YOUR_PASSWORD"
```

Replace `YOUR_PASSWORD` with your local database password.

## Getting Started

### Requirements

- .NET 10 SDK
- PostgreSQL
- Git

### Clone the repository

```bash
git clone https://github.com/Lipe59XD/MyGameList-BackEnd.git
cd MyGameList-BackEnd
```

### Restore dependencies

```bash
dotnet restore
```

### Run the application

```bash
dotnet run
```

The API uses the launch configuration and environment settings to determine its local endpoints.

## API Documentation

OpenAPI support is configured in the application and the document is mapped in the development environment.

The API documentation can be used to inspect available endpoints and their request/response definitions as the API evolves.

## Development Goals

- Build a backend for a full-stack web application.
- Practice REST API development with ASP.NET Core.
- Work with relational databases and Entity Framework Core.
- Organize code using separated responsibilities.
- Develop practical experience with backend architecture and application development.

## Related Repository

[MyGameList Frontend](https://github.com/Lipe59XD/MyGameList-FrontEnd)

---

A personal project developed for learning, experimentation, and continuous improvement in software engineering.
