# OnionArchitectureApp

A clean and extensible .NET 9 solution demonstrating Onion Architecture with CQRS, MediatR, AutoMapper, EF Core, and In-Memory Database for rapid development and testing.

---

## Features

- Onion Architecture layered solution  
- CQRS pattern with MediatR  
- AutoMapper for object mapping  
- EF Core with In-Memory database provider for testing  
- Repository pattern abstraction  
- Swagger/OpenAPI support for easy API testing  

---

## Getting Started

### Prerequisites

- .NET 9 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- Optional: IDE such as Visual Studio or VS Code  

### Running the application

1. Clone the repository:  
   `git clone https://github.com/ArafatYilmaz01/OnionArchitectureApp.git`  
   `cd OnionArchitectureApp`  

2. Navigate to the WebApi project:  
   `cd src/WebApi/OnionArchitectureApp.WebApi`  

3. Run the application:  
   `dotnet run`  

4. Open your browser and navigate to:  
   `https://localhost:5001/swagger`  

Use Swagger UI to explore the API endpoints.

---

## Project Structure

| Layer                        | Purpose                                          |
|------------------------------|-------------------------------------------------|
| OnionArchitectureApp.Domain   | Entities and domain logic                         |
| OnionArchitectureApp.Application | Business logic, CQRS handlers, DTOs            |
| OnionArchitectureApp.Persistence | EF Core DbContext, repositories                 |
| OnionArchitectureApp.WebApi   | API controllers, middleware, and DI registrations |

---

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests.

---

## License

This project is licensed under the MIT License - see the LICENSE file for details.

---

## Contact

Created by [Arafat Yilmaz](https://www.linkedin.com/in/arafat-yilmaz/)
