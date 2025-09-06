**--- Commander API ---**

A learning project built with **ASP.NET Core 9** and **Entity Framework Core** using **SQL Server**.  
Implements CRUD operations to manage CLI commands.

--- Features ---

- Get all commands  
- Get a command by `Id`  
- Create a new command  
- Update an existing command  
- Delete a command  

--- Tech Stack ---

- **ASP.NET Core 9** (Web API)  
- **Entity Framework Core 9** + **SQL Server**  
- **AutoMapper**  
- **Newtonsoft.Json** (CamelCase serialization)  
- **Swagger / OpenAPI**  

--- Entity ---

`Command`  
- `Id` *(int)* — unique identifier  
- `HowTo` *(string)* — description of what the command does  
- `Line` *(string)* — the actual CLI command  
- `Platform` *(string)* — platform where the command runs  


--- Project Structure ---

Controllers/ - API endpoints

Models/ - EF Core entities

DTOs/ - Data Transfer Objects

Services/ - Business logic

Data/ - DbContext and migrations

