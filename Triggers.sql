-- update product quantity after an order is placed
--CREATE TRIGGER UpdateProductQuantity
--ON OrderDetails
--AFTER INSERT
--AS
--BEGIN
--    DECLARE @ProductID INT, @Quantity INT;
--    SELECT @ProductID = ProductID, @Quantity = Quantity FROM inserted;

--    UPDATE Products
--    SET Quantity = Quantity - @Quantity
--    WHERE ProductID = @ProductID;
--END;


--Trigger to Check Product Quantity before Order
--CREATE TRIGGER PreventZeroQuantityOnOrderInsert
--ON Orders
--INSTEAD OF INSERT
--AS
--BEGIN
--    IF EXISTS (
--        SELECT 1
--        FROM inserted i
--        INNER JOIN OrderDetails od ON i.OrderID = od.OrderID
--        INNER JOIN Products p ON od.ProductID = p.ProductID
--        WHERE p.Quantity = 0
--    )
--    BEGIN
--        RAISERROR ('Cannot add order with items having zero quantity!', 16, 1);
--        ROLLBACK TRANSACTION;
--    END
--END;

