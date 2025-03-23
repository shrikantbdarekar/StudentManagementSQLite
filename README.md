# StudentManagementSQLite

# C# Windows Application (.NET 8) with SQLite - CRUD Operations

## 📌 Project Overview
This project is a **Windows Forms (WinForms) application** built with **.NET 8** that implements **CRUD (Create, Read, Update, Delete) operations** using an **SQLite database**. The application manages student records, allowing users to add, view, update, and delete student details.

## 🛠 Technologies Used
- **.NET 8 (WinForms)**
- **C#**
- **SQLite Database**
- **Entity Framework Core**

## 📂 Project Structure
```
📁 StudentManagementSystem
 ┣ 📂 Migrations         # EF Core migration files
 ┣ 📂 Model              # Contains the Student model
 ┣ 📂 Data               # AppDbContext.cs (Database context)
 ┣ 📜 Program.cs         # Entry point of the application
 ┣ 📜 FormLogin.cs       # Login form UI (No Code)
 ┣ 📜 FormStudents.cs    # Main form handling CRUD operations
 ┣ 📜 students.db        # SQLite database file
 ┗ 📜 README.md          # Project documentation
```

## 🚀 Getting Started
Follow these steps to set up and run the project:

### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/shrikantbdarekar/StudentManagementSQLite.git
cd StudentManagementSystem
```

### **2️⃣ Install Dependencies**
Make sure you have the latest .NET 8 SDK installed. Then install EF Core packages:
```sh
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### **3️⃣ Apply Database Migrations**
Run the following commands to create the SQLite database:
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```
✅ This will generate `students.db` and create the `Students` table.

### **4️⃣ Run the Application**
```sh
dotnet run
```
Alternatively, open the project in **Visual Studio 2022**, set `Form1.cs` as the startup form, and press **F5**.

## 📌 Features
- ✅ **Add New Students** (Name, Age, Course)
- ✅ **View Student Records** (DataGridView integration)
- ✅ **Update Student Details**
- ✅ **Delete Students from Database**
- ✅ **Data Persistence using SQLite**

## 📖 Database Schema (`students.db`)
```sql
CREATE TABLE Students (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Age INTEGER NOT NULL,
    Course TEXT NOT NULL
);
```

## 🔧 CRUD Operations Implementation
### **🔹 Create (Insert Student)**
```csharp
var student = new Student { Name = "John Doe", Age = 22, Course = "Computer Science" };
context.Students.Add(student);
context.SaveChanges();
```

### **🔹 Read (Retrieve Students)**
```csharp
var students = context.Students.ToList();
dataGridView1.DataSource = students;
```

### **🔹 Update (Modify Student Details)**
```csharp
var student = context.Students.Find(1);
if (student != null) {
    student.Name = "Updated Name";
    context.SaveChanges();
}
```

### **🔹 Delete (Remove a Student)**
```csharp
var student = context.Students.Find(1);
if (student != null) {
    context.Students.Remove(student);
    context.SaveChanges();
}
```

## 🐞 Troubleshooting
**SQLite Error 1: 'No such table: Students'**
- Ensure you've run `dotnet ef database update` to apply migrations.
- Check if `students.db` exists in your project directory.

**Database Locked Issue**
- Close `students.db` if open in DB Browser for SQLite.
- Restart Visual Studio and retry.

## 📜 License
This project is open-source and available under the **MIT License**.

