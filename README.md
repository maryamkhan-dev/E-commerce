# Bookstore E-commerce Desktop Application

A full-featured Windows Forms desktop application for managing a bookstore's complete e-commerce workflow — from customer shopping and order processing to inventory management and sales reporting.

---

## Overview

This application supports three distinct user roles (Customer, Inventory Manager, Store Manager), each with their own interface and permissions. The system is backed by a MS SQL Server database and handles everything from product browsing and cart management to discount administration and order report generation.

---

## Features

### Customer
- Registration and login with profile management
- Browse the full book catalog with search and filtering
- Add items to shopping cart and manage quantities
- Apply discount coupons at checkout
- View order confirmation and full order history

### Store Manager
- Dashboard for sales overview and order reports
- Manage discount rules and promotional coupons
- View all customer orders and update order status
- Register additional manager or staff accounts

### Inventory Manager
- Add, update, and remove books from inventory
- Track stock levels and pricing
- Manage book metadata (title, author, ISBN, publisher, year)

### System
- Role-based access control with separate login flows
- Full CRUD operations via MS SQL Server
- Relational database with ERD-designed schema
- Windows Forms UI with multi-screen navigation

---

## Tech Stack

| Component  | Technology                        |
|------------|-----------------------------------|
| Language   | C#                                |
| Framework  | .NET Windows Forms                |
| Database   | MS SQL Server                     |
| IDE        | Visual Studio 2019+               |
| Schema     | SQL scripts (T-SQL)               |

---

## Screenshots

> **Login / Role Selection**

![Login](screenshots/login.png)

> **Customer — Book Catalog & Shopping Cart**

![Shop](screenshots/shop.png)

> **Store Manager — Order Reports & Discounts**

![Manager](screenshots/manager.png)

> **Inventory Management**

![Inventory](screenshots/inventory.png)

---

## How to Run

### Prerequisites
- Windows OS
- .NET Framework 4.7.2 or higher
- MS SQL Server (Express or full edition)
- Visual Studio 2019 or later

### Steps

1. **Set up the database**
   - Open SQL Server Management Studio (SSMS)
   - Run the scripts in `CreationTables.txt` to create the schema
   - Run `SQLFunctions.txt` to add stored procedures and functions
   - Update the connection string in `DataBase.cs` with your server name and credentials:
     ```csharp
     string connectionString = "Server=YOUR_SERVER;Database=BookstoreDB;Trusted_Connection=True;";
     ```

2. **Open the solution**
   - Launch Visual Studio
   - Open `my project.sln`
   - Restore NuGet packages if prompted

3. **Build and run**
   - Build the solution with **F6**
   - Run with **F5**
   - The application launches to the role selection / login screen

---

## Project Structure

```
my project/
├── my project.sln              # Visual Studio solution file
└── my project/
    ├── Program.cs              # Application entry point
    ├── DataBase.cs             # SQL Server connection & queries
    ├── Book.cs                 # Book entity class
    ├── Customer.cs             # Customer entity class
    ├── Manager.cs              # Manager entity class
    ├── CustomerOrder.cs        # Order entity class
    ├── Coupon.cs               # Coupon entity class
    ├── Discount.cs             # Discount rules class
    ├── InventoryManager.cs     # Inventory manager entity
    ├── CreationTables.txt      # SQL schema creation script
    ├── SQLFunctions.txt        # SQL stored procedures & functions
    ├── *.cs / *.Designer.cs    # Windows Forms screens
    └── App.config              # Application configuration
```

---

## Database Design

ERD and relational schema diagrams are included in the repository root:
- `22i2514_22i8764_ERD.png` — Entity Relationship Diagram
- `22i2514_22i8764_EERD.png` — Enhanced ERD
- `22i2514_22i8764_Relational Schema.png` — Final relational schema

---

## Authors

Developed as a Software Engineering course project.

**Maryam Khan** — [GitHub](https://github.com/maryamkhan-dev)
