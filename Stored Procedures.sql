-- stored procedure to retrieve all orders for a specific customer
--CREATE PROCEDURE GetOrdersForCustomer
--    @CustomerID INT
--AS
--BEGIN
--    SELECT * FROM Orders WHERE CustomerID = @CustomerID;
--END;

-- Add a new employee to the database.
--CREATE PROCEDURE AddNewEmployee
--    @Username NVARCHAR(50),
--    @Password NVARCHAR(50),
--    @IsManager BIT,
--    @FirstName NVARCHAR(100),
--	@LastName NVARCHAR(100),
--    @Email NVARCHAR(100),
--    @PhoneNumber NVARCHAR(20),
--    @Address NVARCHAR(255),
--    @JoinDate DATE,
--    @Salary DECIMAL(10, 2),
--    @HourlyRate DECIMAL(8, 2)
--AS
--BEGIN
--    INSERT INTO Employees (Username, Password, IsManager, FirstName,LastName, Email, PhoneNumber, Address, JoinDate, Salary, HourlyRate)
--    VALUES (@Username, @Password, @IsManager, @FirstName,@LastName, @Email, @PhoneNumber, @Address, @JoinDate, @Salary, @HourlyRate);
--END;

-- Retrieve the total sales of a specific product.
--CREATE PROCEDURE GetTotalSalesByProduct
--    @ProductID INT
--AS
--BEGIN
--    SELECT p.Name AS ProductName, s.Name, SUM(od.Quantity) AS TotalSales
--    FROM OrderDetails od
--    INNER JOIN Products p ON od.ProductID = p.ProductID
--    INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--    WHERE od.ProductID = @ProductID
--    GROUP BY p.Name, s.Name;
--END;


--calculates payroll for employees
--CREATE PROCEDURE CalculateEmployeePayroll
--AS
--BEGIN
--    -- Variables to hold calculated values
--    DECLARE @TotalPayroll DECIMAL(12, 2);

--    -- Calculate payroll for non-managers based on hourly rates and working hours
--    SET @TotalPayroll = (
--        SELECT SUM((e.HourlyRate * DATEDIFF(HOUR, es.ShiftStart, es.ShiftEnd)) + e.Salary) AS TotalPay
--        FROM Employees e
--        LEFT JOIN EmployeeSchedule es ON e.EmployeeID = es.EmployeeID
--    );

--    -- Display the total payroll
--    SELECT @TotalPayroll AS TotalPayroll;
--END;

-- generates a bill receipt for a specific order
--CREATE PROCEDURE GenerateBillReceipt
--    @OrderID INT
--AS
--BEGIN
--    -- Variables to hold bill receipt information
--    DECLARE @CustomerName NVARCHAR(100);
--    DECLARE @CustomerEmail NVARCHAR(100);
--    DECLARE @OrderDate DATETIME;
--    DECLARE @ProductName NVARCHAR(100);
--    DECLARE @Quantity INT;
--    DECLARE @Subtotal DECIMAL(10, 2);
--    DECLARE @TotalAmount DECIMAL(10, 2);

--    -- Fetching order and customer details
--   SELECT @CustomerName = c.FirstName + ' ' + c.LastName,
--       @CustomerEmail = c.Email,
--       @OrderDate = o.OrderDate
--FROM Orders o
--INNER JOIN Customers c ON o.CustomerID = c.CustomerID
--WHERE o.OrderID = @OrderID;


--    -- Creating a temporary table to store product details for the order
--    CREATE TABLE #TempBillReceipt (
--        ProductName NVARCHAR(100),
--        Quantity INT,
--        Subtotal DECIMAL(10, 2)
--    );

--    -- Fetching product details for the order and calculating subtotal for each product
--    INSERT INTO #TempBillReceipt (ProductName, Quantity, Subtotal)
--    SELECT p.Name, od.Quantity, od.Subtotal
--    FROM OrderDetails od
--    INNER JOIN Products p ON od.ProductID = p.ProductID
--    WHERE od.OrderID = @OrderID;

--    -- Fetching total amount for the order
--    SELECT @TotalAmount = SUM(Subtotal) FROM #TempBillReceipt;

--    -- Displaying the bill receipt
--    SELECT 
--        'Customer Name: ' + @CustomerName AS 'Customer Name',
--        'Customer Email: ' + @CustomerEmail AS 'Customer Email',
--        'Order Date: ' + CONVERT(NVARCHAR(30), @OrderDate, 120) AS 'Order Date';

--    SELECT '--- Product Details ---' AS 'Product Details';
--    SELECT * FROM #TempBillReceipt;

--    SELECT '--- Total Amount ---' AS 'Total Amount';
--    SELECT @TotalAmount AS 'Total Amount';

--    -- Drop temporary table
--    DROP TABLE #TempBillReceipt;
--END;

-- calculate total amount of a order
--CREATE PROCEDURE CalculateOrderTotal
--    @OrderID INT
--AS
--BEGIN
--    DECLARE @TotalAmount DECIMAL(10, 2);

--    SELECT @TotalAmount = SUM(Subtotal)
--    FROM OrderDetails
--    WHERE OrderID = @OrderID;

--    -- Displaying the calculated total amount for the order
--    SELECT @TotalAmount AS TotalAmount;
--END;