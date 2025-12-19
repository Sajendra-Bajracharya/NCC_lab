**# For tha Database Connection **

Step 1: Install & Connect to SQL Server

Install SQL Server (Developer or Express)

Install SQL Server Management Studio (SSMS)

Open SSMS

Connect using:

Server type: Database Engine

Authentication: Windows Authentication

Click Connect

tep 2: Create a Database (CompanyDB)

In SSMS, click New Query, then run:

CREATE DATABASE CompanyDB;


Now select the database:

USE CompanyDB;

**Step 3: Create the Employees Table**
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    HireDate DATE
);


✅ IDENTITY(1,1) auto-increments EmployeeID

Step 4: Insert Sample Data
INSERT INTO Employees (FirstName, LastName, Department, Salary, HireDate)
VALUES
('John', 'Doe', 'IT', 60000, '2022-01-15'),
('Jane', 'Smith', 'HR', 55000, '2021-03-20'),
('Michael', 'Brown', 'Finance', 70000, '2020-07-10'),
('Emily', 'Davis', 'IT', 65000, '2023-02-05');
