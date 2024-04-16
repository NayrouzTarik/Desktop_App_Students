# 📊 Data Management System (Windows Forms App)

This project is a simple data management system implemented as a Windows Forms application using C#. It allows users to interact with a PostgreSQL database to perform CRUD (Create, Read, Update, Delete) operations on a simple student data.

## 🚀 Features

- **Check Connection**: Verify the connection status to the PostgreSQL database.
- **Add Data**: Insert new student records into the database.
- **Delete Data**: Remove selected student records from the database.
- **Update Data**: Modify existing student records in the database.
- **Display Data**: View student data in a DataGridView.

## ⚙️ Prerequisites

- **PostgreSQL**: You need to have PostgreSQL installed and running on your local machine or a remote server. Ensure you have the necessary database schema set up for student data manipulation.

## 🛠️ Setup

1. Clone or download the repository to your local machine.
2. Open the project in Visual Studio or any other C# IDE.
3. Make sure to install the Npgsql package using NuGet Package Manager.
4. Update the connection string in the `Form1` constructor to match your PostgreSQL server configuration (host, port, database, username, password).

## 📋 Usage

1. Run the application.
2. Click the "Check Connection" button to verify the connection status.
3. Use the "Add Data", "Delete Data", and "Update Data" buttons to perform CRUD operations on student records.
4. The DataGridView displays the current student data fetched from the PostgreSQL database.
5. You can input new student information in the textboxes provided.

## 🛠️ Troubleshooting

- If you encounter any issues with the database connection or CRUD operations, ensure that your PostgreSQL server is running and that the connection string in the code is correctly configured.

