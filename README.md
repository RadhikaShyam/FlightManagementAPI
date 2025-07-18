# ✈️ Flight Management API

A secure and scalable RESTful API built with **ASP.NET Core Web API (C#)** for managing flight operations . This backend system uses **SQL Server** for data storage and **JWT** (JSON Web Token) for authentication and role-based authorization.

---

## 🧰 Technologies Used

- **ASP.NET Core Web API (C#)**
- **Entity Framework Core**
- **SQL Server**
- **JWT Authentication**
- **Postman**

---

## ✅ Features

### 🔐 Authentication & Authorization

- User registration and login with hashed passwords.
- JWT token generation and validation for secure session handling.
- Role-based access control (Admin, User).

### ✈️ Flight Management

- Create, update, delete, and retrieve flights.
- Flight attributes: flight number, origin, departure/arrival time, price, etc.

### 👥 User & Role Management

- Admin endpoints for managing user roles and access levels.

---

## 🗂 Project Structure

/Controllers
├── AuthController.cs
├── FlightsController.cs

/Models
├── Flight.cs

/DTOs
├── RegisterDto.cs
└── LoginDto.cs
├── FlightDto.cs
└── CreateFlightDto.cs

/Services
└── FlightService.cs

/Data
└── ApplicationDbContext.cs

/Repositories
└── FlightRepository.cs

