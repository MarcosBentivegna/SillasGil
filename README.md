# Sillas Gil - Event Infrastructure Management System

**Sillas Gil** is a web-based application designed to manage the logistics and inventory of a company that provides grandstands, stages, and chairs for parades and religious processions. The goal is to optimize the organization, reservations, and deployment of infrastructure elements for public events.

## 📌 Project Overview

This ASP.NET MVC application allows users to manage:

- **Events** – Create and manage parades or religious processions, including date, location, and logistics.
- **Clients** – Register individuals or institutions who request services.
- **Inventory** – Track availability and condition of chairs, stages, and grandstands.
- **Reservations** – Allocate inventory items to specific events with conflict checking.
- **Logistics** – Assign transport and setup teams, track deployment and return of materials.
- **Reports** – View statistics, revenue summaries, and material usage.

## 💻 Technologies Used

- **.NET 6 / 8**
- **ASP.NET MVC (Model-View-Controller)**
- **Entity Framework Core**
- **SQL Server / LocalDB**
- **Razor Views**
- **Bootstrap (UI styling)**

## 🏗️ Architecture

The project follows a layered architecture:
- `Models/` – Data models and validation
- `Controllers/` – Business logic and routing
- `Views/` – Front-end interface with Razor
- `Data/` – Entity Framework database context

## 🚀 Getting Started

1. Clone the repository
2. Install required NuGet packages:
   - `Microsoft.EntityFrameworkCore.SqlServer`
   - `Microsoft.EntityFrameworkCore.Tools`
3. Configure the connection string in `appsettings.json`
4. Apply migrations to generate the database:
   ```bash
   Update-Database
