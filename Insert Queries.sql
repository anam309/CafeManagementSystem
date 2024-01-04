---- Inserting data into Employees table
--INSERT INTO Employees (Username, Password, IsManager, FirstName, LastName, Email, PhoneNumber, Address, JoinDate, ShiftStartTime, ShiftEndTime, Salary, HourlyRate)
--VALUES ('emp1', 'pass1', 1, 'John', 'Doe', 'john@example.com', '1234567890', '123 Main St', '2023-01-01', '09:00', '17:00', 50000.00, 25.00),
--       ('emp2', 'pass2', 0, 'Jane', 'Smith', 'jane@example.com', '9876543210', '456 Oak St', '2023-01-02', '10:00', '18:00', 40000.00, 20.00);

---- Inserting data into Customers table
--INSERT INTO Customers (Username, Password, FirstName, LastName, Email, PhoneNumber, Address, JoinDate)
--VALUES ('customer1', 'passcust1', 'Alice', 'Johnson', 'alice@example.com', '1112223334', '789 Elm St', '2023-01-05'),
--       ('customer2', 'passcust2', 'Bob', 'Williams', 'bob@example.com', '5556667778', '101 Pine St', '2023-01-08');

---- Inserting data into ProductCategories table
--INSERT INTO ProductCategories (CategoryName, Description)
--VALUES ('Drinks', 'Coffee/Soft Drink/Tea/Water'),
--('Food', 'Pasta/Steak/Fries/Sandwiches/Pizza'),
--       ('Desserts', 'Cakes/Cupcakes/Cookies');

--Inserting in Suppliers Table
  --INSERT INTO [cafe_Management_system].[dbo].[Suppliers] ([Name]
  --    ,[ContactPerson]
  --    ,[Phone]
  --    ,[Email]
  --    ,[Address])
	 -- VALUES ('Dunkin Donuts','Rabbia', '03214543732', 'rabbiakhan@gmail.com','429, A Block'),
	 --('Nestle','Faizan', '03219676066', 'faizankhan@gmail.com','449, TIP Block'),
	 --('Layers','Ahsan', '03219666066', 'ahsankhan@gmail.com','446, TIP Block')

---- Inserting data into Products table
--INSERT INTO Products (Name, Description, Price, Quantity, CategoryId, SupplierId)
--VALUES ('Coffee', 'Freshly brewed coffee', 2.50, 100, 1, 2),
--       ('Sandwich', 'Grilled sandwich', 5.00, 50, 2, 3);

---- Inserting data into Orders table
--INSERT INTO Orders (CustomerID, EmployeeID, OrderDate)
--VALUES (1, 1, '2023-02-15 10:30:00'),
--       (2, 2, '2023-02-18 12:00:00');

---- Inserting data into OrderDetails table
--INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Subtotal)
--VALUES (1, 1, 2, 5.00),
--       (1, 2, 1, 5.00),
--       (2, 2, 3, 15.00);

---- Inserting data into EmployeeCheckInOuts table
--INSERT INTO EmployeeCheckInOuts (EmployeeID, CheckInTime, CheckOutTime, DateCheckInOut)
--VALUES (1, '2023-02-15 09:00:00', '2023-02-15 17:00:00', '2023-02-15'),
--       (2, '2023-02-18 10:00:00', '2023-02-18 18:00:00', '2023-02-18');

---- Inserting data into Feedback table
--INSERT INTO Feedback (CustomerID, FeedbackText, Rating, FeedbackDate)
--VALUES (1, 'Great service!', 5, '2023-02-20'),
--       (2, 'Nice food!', 4, '2023-02-21');

---- Inserting data into Promotions table
--INSERT INTO Promotions (Name, Description, StartDate, EndDate, Discount, ProductCategory)
--VALUES ('Happy Hour', '50% off on all drinks from 4 PM to 6 PM', '2023-03-01', '2023-03-31', 50.00, 1);
