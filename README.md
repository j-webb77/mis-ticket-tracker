# MIS Help Desk Tracker

A database-driven intranet web application designed to track and manage IT support tickets for an enterprise environment. 

## Business Purpose
This application simulates the type of internal business systems used by district technology departments to manage support requests, track issue resolution, and maintain accountability for IT operations. It replaces manual spreadsheets and email-based tracking with a centralized, secure database system.

## Tech Stack
- **Framework:** ASP.NET Core MVC (.NET 8)
- **Language:** C#
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework Core
- **Version Control:** Git
- **Frontend:** Razor Views, Bootstrap 5, HTML5, CSS3

## Features
- **Full CRUD Operations:** Create, Read, Update, and Delete help desk tickets.
- **Database-Driven:** All data is persisted to and retrieved from Microsoft SQL Server.
- **Dynamic UI:** Status badges (Open, In Progress, Closed) are color-coded using Razor logic.
- **Form Validation:** Server-side and client-side validation using C# Data Annotations.
- **Responsive Design:** Bootstrap-based interface that works on desktop and tablet.

## Database Schema
The application uses a single `Tickets` table with the following structure:
- `TicketId` (Primary Key, Identity)
- `Title` (Required, NVARCHAR(100))
- `Description` (NVARCHAR(500))
- `Status` (Required, NVARCHAR(50), Default: 'Open')
- `Priority` (Required, NVARCHAR(20), Default: 'Medium')
- `CreatedDate` (DATETIME, Default: GETDATE())
- `AssignedTo` (NVARCHAR(100))

## Getting Started
1. Clone this repository.
2. Open the solution in Visual Studio.
3. Update the `DefaultConnection` string in `appsettings.json` to point to your SQL Server instance.
4. Run the SQL script in `/Database/Setup.sql` to create the database and table.
5. Press F5 to run the application.

## Architecture Notes
This project follows the **MVC (Model-View-Controller)** pattern to ensure a clean separation of concerns:
- **Models:** Represent the data structure (`Ticket.cs`).
- **Views:** Handle the UI and presentation (`Views/Tickets/*.cshtml`).
- **Controllers:** Manage the business logic and data flow (`TicketsController.cs`).
- **Data Access:** Entity Framework Core acts as the ORM, allowing C# objects to interact with the SQL database without writing raw SQL queries in the application layer.
