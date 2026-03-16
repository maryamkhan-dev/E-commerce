# E-commerce Desktop Application

## Project Title
Bookstore E-commerce Management System

## Description of the System
A comprehensive desktop application for managing a bookstore's e-commerce operations. The system supports multiple user roles including customers, inventory managers, and store managers. It provides functionality for browsing books, managing shopping carts, processing orders, handling inventory, and generating reports.

## Features
- **Customer Management**: User registration, login, profile management, and order history
- **Inventory Management**: Add, update, and remove books from inventory
- **Order Processing**: Shopping cart management, checkout, and order tracking
- **Discount & Coupon System**: Create and manage discounts and promotional coupons
- **Reporting**: Generate order reports and analytics
- **Database Integration**: Full CRUD operations with MS SQL Server
- **Role-based Access**: Different interfaces for customers, managers, and inventory staff

## Tech Stack
- **Language**: C#
- **Framework**: .NET Windows Forms
- **Database**: MS SQL Server
- **IDE**: Visual Studio

## Screenshots
### Login Screen
![Login Screen](https://via.placeholder.com/600x400?text=Login+Screen)

### Customer Dashboard
![Customer Dashboard](https://via.placeholder.com/600x400?text=Customer+Dashboard)

### Inventory Management
![Inventory Management](https://via.placeholder.com/600x400?text=Inventory+Management)

### Order Processing
![Order Processing](https://via.placeholder.com/600x400?text=Order+Processing)

## How to Run the Project
1. **Prerequisites**:
   - Windows OS
   - .NET Framework 4.7.2 or higher
   - MS SQL Server
   - Visual Studio 2019 or later

2. **Setup Database**:
   - Run the SQL scripts in `CreationTables.txt` and `SQLFunctions.txt` to set up the database schema
   - Update the connection string in `DataBase.cs` with your SQL Server credentials

3. **Open Project**:
   - Open `my project.sln` in Visual Studio
   - Restore NuGet packages if required

4. **Build and Run**:
   - Build the solution (F6)
   - Run the application (F5)
   - The application will start with the login screen

5. **Default Credentials** (if applicable):
   - Create manager accounts through the registration form or directly in the database

## Project Structure
- `Forms/`: All Windows Forms and their designers
- `Classes/`: Business logic classes (Book, Customer, Order, etc.)
- `DataBase.cs`: Database connection and operations
- `Program.cs`: Application entry point

## Contributing
This project was developed as part of a software engineering course. For educational purposes only.

## License
This project is for educational use only.