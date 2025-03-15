EmployeeAdmin API

Overview

EmployeeAdmin is a RESTful API built using ASP.NET Core that provides authentication using JWT tokens and allows managing employee records through CRUD operations.

Features

JWT-based authentication

Employee management (Create, Read, Update, Delete)

Secure API endpoints with authentication and authorization

Entity Framework Core with SQL Server

Dependency Injection for service and repository layers

Swagger integration for API documentation

Role-based access control (Admin & User roles)

Technologies Used

ASP.NET Core 6

Entity Framework Core

SQL Server

JWT Authentication

Swagger

AutoMapper



Configure Database Connection

Update the appsettings.json file with your SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeAdminDB;Trusted_Connection=True;"
}

Configure JWT Settings

Add JWT settings in appsettings.json
"JwtSettings": {
  "SecretKey": "your-32-characters-long-secret-key",
  "Issuer": "your-issuer",
  "Audience": "your-audience"
}
Run Database Migrations

dotnet ef database update


dotnet ef database update

dotnet run
Access Swagger API Documentation
Open a browser and go to:

http://localhost:5000/swagger

API Endpoints

Authentication

POST /api/auth/register - Register a new user

POST /api/auth/login - Authenticate user and receive JWT token

Employee Management

GET /api/employees - Get all employees (Requires Authorization)

POST /api/employees - Add a new employee (Requires Admin role)

PUT /api/employees/{id} - Update an employee (Requires Admin role)

DELETE /api/employees/{id} - Delete an employee (Requires Admin role)

Security & Authorization

All employee-related endpoints require a valid JWT token.

Users need to send the token in the Authorization header:

Authorization: Bearer YOUR_JWT_TOKEN

Role-based access control ensures that only admins can create, update, or delete employees.
