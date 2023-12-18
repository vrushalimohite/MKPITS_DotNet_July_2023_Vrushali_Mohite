CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName NVARCHAR(50) NOT NULL
);

-- Insert some sample data into "Departments" table
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'Engineering'),
       (2, 'Marketing'),
       (3, 'Sales');

-- Create an "Employees" table with a foreign key constraint referencing "Departments"
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(50) NOT NULL,
    DepartmentID INT,
    CONSTRAINT FK_Department_Employee FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert some sample data into "Employees" table
INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID)
VALUES (1, 'John Doe', 1),
       (2, 'Jane Smith', 2),
       (3, 'Bob Johnson', 1),
       (4, 'Alice Brown', 3);

-- Query to retrieve employees along with their department names without using explicit joins
SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID;

-- Attempt to insert a record violating the foreign key constraint
-- Uncomment the following lines to see the error
-- INSERT INTO Employees (EmployeeID, EmployeeName, DepartmentID)
-- VALUES (5, 'Sam Wilson', 4);

-- Update the department of an employee
UPDATE Employees
SET DepartmentID = 3
WHERE EmployeeID = 1;

-- Query again to verify the changes
SELECT e.EmployeeID, e.EmployeeName, d.DepartmentName
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID;

select * from Departments
select *  from Employees