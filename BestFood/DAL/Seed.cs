namespace BestFood.DAL
{
    internal class Seed
    {
        private readonly string DbName = "bestfood";
        private readonly TableNames tableNames = new TableNames();

        private struct TableNames
        {
            public string dishesTableName;
            public string categoriesTableName;
            public string ordersTableName;
            public string orderDetailsTableName;

            public TableNames()
            {
                dishesTableName = "dishes";
                categoriesTableName = "categories";
                ordersTableName = "orders";
                orderDetailsTableName = "order_details";
            }
        }
        
        public Seed() { }
        
        public Seed(bool truncate, bool drop)
        {
            if (truncate)
            {
                TruncateAllTables();
            }
            if (drop)
            {
                DropAllTables();
            }
        }

        public void EnsureExists()
        {
            try
            {
                // Ensure the database exists
                CreateDatabase();

                // Ensure the tables exist
                CreateTable(tableNames.categoriesTableName, GetCategoriesTableCreationSql());
                CreateTable(tableNames.dishesTableName, GetDishesTableCreationSql());
                CreateTable(tableNames.ordersTableName, GetOrdersTableCreationSql());
                CreateTable(tableNames.orderDetailsTableName, GetOrderDetailsTableCreationSql());

                // Ensure the data exists (if needed)
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error ensuring database and tables exist: {e.Message}");
            }
        }

        private void CreateDatabase()
        {
            try
            {
                AppSqlHandler.ExecuteNonQuery($"IF DB_ID(N'{DbName}') IS NULL CREATE DATABASE [{DbName}];");
                Console.WriteLine($"Database '{DbName}' created or already exists.");
            }
            catch (Exception e)
            {
                throw new Exception($"Error creating database '{DbName}': {e.Message}");
            }
        }

        private void CreateTable(string tableName, string createTableSql)
        {
            try
            {
                AppSqlHandler.ExecuteNonQuery(createTableSql);
                Console.WriteLine($"Table '{tableName}' created or already exists.");
            }
            catch (Exception e)
            {
                throw new Exception($"Error creating table '{tableName}': {e.Message}");
            }
        }

        private string GetDishesTableCreationSql()
        {
            return $@"
            IF OBJECT_ID('dbo.{tableNames.dishesTableName}', 'U') IS NULL
            BEGIN
                CREATE TABLE dbo.{tableNames.dishesTableName} (
                    DishID INT PRIMARY KEY IDENTITY,
                    CategoryID INT,
                    Name VARCHAR(255) UNIQUE,
                    Price DECIMAL(10, 2),
                    Description VARCHAR(255) NULL,
                    CONSTRAINT FK_Dishes_Categories FOREIGN KEY (CategoryID) REFERENCES dbo.categories(CategoryID)
                );
                PRINT 'Table Created: dbo.{tableNames.dishesTableName}';
            END
            ELSE
            BEGIN
                PRINT 'Table Exists: dbo.{tableNames.dishesTableName}';
            END";
        }

        private string GetCategoriesTableCreationSql()
        {
            return $@"
            IF OBJECT_ID('dbo.{tableNames.categoriesTableName}', 'U') IS NULL
            BEGIN
                CREATE TABLE dbo.{tableNames.categoriesTableName} (
                    CategoryID INT PRIMARY KEY IDENTITY,
                    Name VARCHAR(255) UNIQUE
                );
                PRINT 'Table Created: dbo.{tableNames.categoriesTableName}';
            END
            ELSE
            BEGIN
                PRINT 'Table Exists: dbo.{tableNames.categoriesTableName}';
            END";
        }

        private string GetOrdersTableCreationSql()
        {
            return $@"
            IF OBJECT_ID('dbo.{tableNames.ordersTableName}', 'U') IS NULL
            BEGIN
                CREATE TABLE dbo.{tableNames.ordersTableName} (
                    OrderID INT PRIMARY KEY IDENTITY,
                    OrderDate DATETIME,
                    TotalAmount DECIMAL(10, 2),
                    Status VARCHAR(255)
                );
                PRINT 'Table Created: dbo.{tableNames.ordersTableName}';
            END
            ELSE
            BEGIN
                PRINT 'Table Exists: dbo.{tableNames.ordersTableName}';
            END";
        }

        private string GetOrderDetailsTableCreationSql()
        {
            return $@"
            IF OBJECT_ID('dbo.{tableNames.orderDetailsTableName}', 'U') IS NULL
            BEGIN
                CREATE TABLE dbo.{tableNames.orderDetailsTableName} (
                    OrderDetailID INT PRIMARY KEY IDENTITY,
                    OrderID INT,
                    DishID INT,
                    Quantity INT,
                    Price DECIMAL(10, 2),
                    CONSTRAINT FK_OrderDetails_Orders FOREIGN KEY (OrderID) REFERENCES dbo.orders(OrderID),
                    CONSTRAINT FK_OrderDetails_Dishes FOREIGN KEY (DishID) REFERENCES dbo.dishes(DishID)
                );
                PRINT 'Table Created: dbo.{tableNames.orderDetailsTableName}';
            END
            ELSE
            BEGIN
                PRINT 'Table Exists: dbo.{tableNames.orderDetailsTableName}';
            END";
        }

        public static void TruncateAllTables()
        {
            try
            {
                AppSqlHandler.ExecuteNonQuery("TRUNCATE TABLE categories;");
                AppSqlHandler.ExecuteNonQuery("TRUNCATE TABLE dishes;");
                AppSqlHandler.ExecuteNonQuery("TRUNCATE TABLE orders;");
                AppSqlHandler.ExecuteNonQuery("TRUNCATE TABLE order_details;");
                Console.WriteLine("All tables truncated successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error truncating tables: " + e.Message);
            }
        }

        public static void DropAllTables()
        {
            try
            {
                AppSqlHandler.ExecuteNonQuery("DROP TABLE order_details;");
                AppSqlHandler.ExecuteNonQuery("DROP TABLE orders;");
                AppSqlHandler.ExecuteNonQuery("DROP TABLE dishes;");
                AppSqlHandler.ExecuteNonQuery("DROP TABLE categories;");
                Console.WriteLine("All tables dropped successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error dropping tables: " + e.Message);
            }
        }

    }
}
