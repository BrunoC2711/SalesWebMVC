# SalesWebMVC
This project is my first practical with a project in english and MVC

# MVC Project Instructions

## Overview
This MVC project aims to create a web application using the Model-View-Controller (MVC) architectural pattern. The application will be built using C# and ASP.NET Core.

## Prerequisites
Make sure you have the following installed on your system:
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## Steps

### Step 1: Open the project in your preferred code editor
 - Open Visual Studio Code or Visual Studio.
 - Open the folder containing your newly created project.

### Step 2: Configure connection string
Open the appsettings.json file.
Add or modify the "ConnectionStrings" section to configure your database connection. For example:

{
  "ConnectionStrings": {
    "SalesWebMVCContext": "Server=localhost; Database=saleswebmvc; UserId=root; Password=saleswebmvcpass;"
  }
}

```csharp
// Seu código C# aqui
public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        Console.WriteLine("Hello, world!");
    }
}
```

Replace "SalesWebMVCContext" with your preferred connection name and update the connection string with your database details.

### Step 3 : Create Database
Run the following command to create the database and apply migrations:

   dotnet ef database update

### Step 4: Run the project
In your terminal or command prompt, navigate to the project directory.
Run the following command to start the application:

   dotnet run

Conclusion
You've now created a basic MVC project using ASP.NET Core and configured the connection string for your database. Continue building and customizing your application according to your requirements.

Feel free to customize the instructions further based on your specific project needs.





