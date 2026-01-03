# College Enrollment System API

🚧 **Status: Under Development** 🚧

This repository contains the backend **REST API** for the **College Enrollment System**, built using **ASP.NET Core Web API**. The project is currently **under active development**, and features, endpoints, and response formats may change.

---

## 📌 Project Overview

The API is designed to support a college enrollment platform with features such as:

* User authentication and authorization (JWT-based)
* Role-based access (Admin, Student)
* Student management
* Enrollment workflows
* Standardized API responses
* API versioning

---

## 🛠️ Tech Stack

### Backend

* **Framework:** ASP.NET Core Web API
* **Language:** C#
* **Authentication:** ASP.NET Core Identity + JWT
* **Database:** SQL Server (via Entity Framework Core)
* **ORM:** Entity Framework Core
* **API Documentation:** Swagger / OpenAPI

### Frontend

* **Framework:** React.js
* **UI Layer:** Consumes this API via REST

---

## 📦 API Response Standard

All endpoints return a **standardized JSON response** format for consistency and frontend integration.

Example success response:

```json
{
  "success": true,
  "message": "Operation successful",
  "data": {
    "id": 1,
    "email": "user@example.com"
  }
}
```

Example error response:

```json
{
  "success": false,
  "message": "Validation failed",
  "errors": {
    "email": ["Email is required"]
  }
}
```

---

## 🔐 Authentication

* Uses **JWT Bearer Authentication**
* Login returns an access token with expiration
* Logout is handled client-side (JWT is stateless)

---

## 📄 API Versioning

The API supports versioning using URL segments:

```
/api/v1/auth/login
/api/v1/auth/register
```

---

## 📘 Swagger Documentation

Swagger UI is enabled in development mode for testing and documentation:

```
https://localhost:{port}/swagger
```

---

## 🚀 Running the Project

1. Clone the repository
2. Update `appsettings.Development.json` with your database and JWT settings
3. Run database migrations:

```bash
dotnet ef database update
```

4. Run the API:

```bash
dotnet run
```

---

## ⚠️ Development Status

This project is **not production-ready** yet.

Planned improvements include:

* Better error handling
* Pagination and filtering
* Refresh tokens
* More test coverage
* Deployment configuration

---

## 📄 License

This project is for learning and portfolio purposes.

---

## ✍️ Author

**Chicote Belsonda**
Backend / Full-Stack Developer
