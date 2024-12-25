select * from users
truncate table users
CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Employee_Id NVARCHAR(100) UNIQUE NOT NULL, 
    Full_Name NVARCHAR(100) NOT NULL,
    Gender CHAR(1) CHECK (Gender IN ('M', 'F')), 
    Contact_Number NVARCHAR(30), 
    Position NVARCHAR(50), 
    Salary DECIMAL(10, 2) CHECK (Salary >= 0),
    Image NVARCHAR(MAX), 
    Insert_Date DATETIME NOT NULL DEFAULT GETDATE(),
    Update_Date DATETIME NOT NULL DEFAULT GETDATE(),
    Delete_Date DATETIME NOT NULL DEFAULT GETDATE() 
);

Select * from Employees
 Alter Table Employees
 Add Status NVARCHAR(20) NOT NULL DEFAULT 'Active'

 Select * from employees where delete_date IS NULL

 INSERT INTO Employees (Employee_Id, Full_Name, Gender, Contact_Number, Position, Salary, Image, Status)
VALUES 
('EMP001', 'Ahmed Omar', 'M', '0123456789', 'Software Engineer', 15000.00, NULL, 'Active'),
('EMP002', 'Sara Khaled', 'F', '0111234567', 'Project Manager', 25000.00, NULL, 'Active'),
('EMP003', 'Mohamed Ali', 'M', '0109876543', 'UI/UX Designer', 12000.00, NULL, 'On Leave'),
('EMP004', 'Laila Hassan', 'F', '0123451122', 'Quality Analyst', 14000.50, NULL, 'Inactive'),
('EMP005', 'Omar Youssef', 'M', '0111111111', 'DevOps Engineer', 18000.75, NULL, 'Active'),
('EMP006', 'Nour Tarek', 'F', '0102222333', 'HR Specialist', 10000.00, NULL, 'Active'),
('EMP007', 'Khaled Ezz', 'M', '0123333444', 'Business Analyst', 16000.00, NULL, 'On Leave'),
('EMP008', 'Amal Farid', 'F', '0114444555', 'Software Engineer', 15500.00, NULL, 'Active'),
('EMP009', 'Hassan Adel', 'M', '0105555666', 'Technical Lead', 30000.00, NULL, 'Inactive'),
('EMP010', 'Reem Mohamed', 'F', '0126666777', 'Marketing Manager', 20000.00, NULL, 'Active');