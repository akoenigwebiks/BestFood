--IF OBJECT_ID('dbo.orders', 'U') IS NULL
--BEGIN
--    CREATE TABLE dbo.orders (
--        OrderDetailID INT PRIMARY KEY IDENTITY,
--        OrderID INT,
--        DishID INT,
--        Quantity INT,
--        Price DECIMAL(10, 2),
--        CONSTRAINT FK_OrderDetails_Orders FOREIGN KEY (OrderID) REFERENCES dbo.orders(OrderID),
--        CONSTRAINT FK_OrderDetails_Dishes FOREIGN KEY (DishID) REFERENCES dbo.dishes(DishID)
--    );
--    PRINT 'Table Created: dbo.orders';
--END
--ELSE
--BEGIN
--    PRINT 'Table Exists: dbo.orders';
--END

--IF OBJECT_ID('dbo.categories', 'U') IS NULL
--BEGIN
--    CREATE TABLE dbo.categories (
--        CategoryID INT PRIMARY KEY IDENTITY,
--        Name VARCHAR(255)
--    );
--    PRINT 'Table Created: dbo.categories';
--END
--ELSE
--BEGIN
--    PRINT 'Table Exists: dbo.categories';
--END

-- Create a temporary table to store the result
IF OBJECT_ID('tempdb..#TableStatus') IS NOT NULL
    DROP TABLE #TableStatus;

CREATE TABLE #TableStatus (
    [exists] TINYINT,
    [created] TINYINT
);

-- Check if the 'categories' table exists
DECLARE @Exists TINYINT = 0, @Created TINYINT = 0;

IF OBJECT_ID('dbo.categories', 'U') IS NOT NULL
BEGIN
    -- Table already exists
    SET @Exists = 1;
    SET @Created = 0;
    PRINT 'Table Exists: dbo.categories';
END
ELSE
BEGIN
    -- Table does not exist, create it
    CREATE TABLE dbo.categories (
        CategoryID INT PRIMARY KEY IDENTITY,
        Name VARCHAR(255)
    );
    SET @Exists = 0;
    SET @Created = 1;
    PRINT 'Table Created: dbo.categories';
END

-- Insert the result into the temporary table
INSERT INTO #TableStatus ([exists], [created])
VALUES (@Exists, @Created);

-- Select the result from the temporary table
SELECT [exists], [created] FROM #TableStatus;

-- Clean up: Drop the temporary table
DROP TABLE #TableStatus;

