# W3D1-CRUDoperations
# Employee Management System - ASP.NET Core MVC

This project is an Employee Management System built using ASP.NET Core MVC. It implements CRUD (Create, Read, Update, Delete) operations to manage employee records in a simple web application. The application uses Entity Framework Core for database access.

## Features
- **Create Employee:** Add new employee records.
- **Read Employee:** Display a list of employees.
- **Update Employee:** Modify employee details.
- **Delete Employee:** Remove an employee from the system.
- **Database Integration:** Utilizes Entity Framework Core to interact with the database.

## Setup Instructions

Follow the steps below to get the application up and running on your local machine.

### Prerequisites

1. **.NET 6 or higher**: This project uses ASP.NET Core 6, so make sure you have the latest .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).
2. **SQL Server**: The application uses a local SQL Server database. You can use [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [LocalDB](https://docs.microsoft.com/en-us/sql/ssds/download-sql-server-management-studio-ssms?view=sql-server-ver15).

### Step-by-Step Setup

1. **Clone the repository**

   Clone this project to your local machine using the following command:

   ```bash
   git clone https://github.com/Aomsh2000/W3D1-CRUDoperations.git

## CRUD Operations
Create Employee:

Navigate to the "Create Employee" page from the home page.
Fill in the employee details (Name, Position, Salary) and click "Save" to add the employee.
View Employees:

Navigate to the "Employee List" page to see all employees.
You can view employee details, and use options to edit or delete.
Edit Employee:

From the employee list, click "Edit" to modify an employee's details.
Update the fields and save the changes.
Delete Employee:

From the employee list, click "Delete" to remove an employee.
Confirm the deletion before it is performed.

## Routing and Endpoints
GET /Employees: Lists all employees.
GET /Employees/Create: Display the form to add a new employee.
POST /Employees/Create: Handles the submission of the form to create a new employee.
GET /Employees/Edit/{id}: Display the form to edit an employee's details.
POST /Employees/Edit/{id}: Handles the submission of the form to update employee details.
GET /Employees/Delete/{id}: Display the confirmation page to delete an employee.
POST /Employees/Delete/{id}: Handles the deletion of an employee.

 ## Technologies Used
ASP.NET Core MVC: Used for building the web application with the MVC pattern.
Entity Framework Core: ORM used for database access and operations.
SQL Server LocalDB: Local database server for development.
Razor Views: Used to render HTML content dynamically.

## Project Structure
The project is organized as follows:

EmployeeManagementSystem/
├── Controllers/
│   └── EmployeeController.cs        # CRUD operations for employees
├── Models/
│   └── Employee.cs                 # Employee model with data annotations
│   └── AppDbContext.cs            # Database context for Entity Framework
├── Views/
│   └── Employee/
│       ├── Index.cshtml            # Display list of employees
│       ├── Create.cshtml           # Create a new employee form
│       ├── Edit.cshtml             # Edit employee details form
│       ├── Delete.cshtml           # Confirm delete page
├── appsettings.json                # Configuration file for the application
├── Program.cs                      # Main entry point for the application
└── Startup.cs                      # Configures services and the HTTP request pipeline

## Troubleshooting
404 Error (Page Not Found): Ensure that your routes are configured correctly and that the controller actions match the URLs.
Database Errors: Make sure your database is set up and that the connection string in appsettings.json is correct.