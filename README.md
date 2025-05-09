# TODO Application

A simple web application where you can add tasks and mark them as completed.

## Getting Started

Follow these instructions to set up and run the project on your local machine.

### Prerequisites
- .NET Core SDK (version specified in the project)
- SQL Server (or the database system specified in the project)
- Visual Studio or your preferred IDE

### Installation

1. **Download the project**
   - Download the ZIP file from the repository
   - Extract the contents to your preferred directory

2. **Database Setup**
   - Open the project in your IDE
   - Locate the `AppDbContext` class
   - Modify the connection string to match your local database configuration

3. **Run the application**
   - Build the solution to restore NuGet packages
   - Run the application (F5 in Visual Studio)

## Features
- Add new tasks to your TODO list
- Mark tasks as completed
- View all your current tasks

## Project Structure
- `AppDbContext.cs` - Database context and configuration
- `Models/` - Contains the Task model
- `Controllers/` - Application controllers
- `Views/` - UI components

## Troubleshooting
If you encounter any issues:
- Verify your database connection string
- Ensure all required NuGet packages are installed
- Check that your .NET Core version matches the project requirements
