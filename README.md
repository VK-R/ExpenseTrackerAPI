# 💸 Expense Tracker API

A simple, clean RESTful API built using **ASP.NET Core (.NET 8)** to manage daily expenses. This project follows a clean architecture with separation of concerns (API, Application, Infrastructure, Domain).

---

## 🚀 Features

- ✅ Add new expenses
- ✅ Get all expenses
- ✅ Get expense by ID
- 📦 Built using Entity Framework Core & SQLite
- 🌐 Swagger UI for API testing

---

## 📁 Project Structure

ExpenseTrackerAPI/ ├── ExpenseTracker.API → Entry point (Web API) ├── ExpenseTracker.Application → Business logic layer ├── ExpenseTracker.Infrastructure→ EF Core DbContext + DB setup ├── ExpenseTracker.Domain → Entity models


---

## 🛠️ Tech Stack

- .NET 8 (ASP.NET Core Web API)
- Entity Framework Core
- SQLite (can be switched to SQL Server)
- Swagger / Swashbuckle

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/ExpenseTrackerAPI.git
cd ExpenseTrackerAPI
