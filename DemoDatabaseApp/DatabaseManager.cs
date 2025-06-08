using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoDatabaseApp
    {
    public class DatabaseManager
        {
        private string connectionString;

        public DatabaseManager()
            {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
                {
                // Fallback connection string for SQL Server Express
                connectionString = @"Server=.\SQLEXPRESS;Database=POSSystemDB;Integrated Security=true;";
                }
            }

        public bool TestConnection()
            {
            try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    connection.Open();
                    return true;
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Connection Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            }

        // Create database tables if they don't exist
        public void InitializeDatabase()
            {
            try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    connection.Open();

                    // Create Categories table
                    string createCategoriesTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Categories' AND xtype='U')
                        CREATE TABLE Categories (
                            CategoryId INT IDENTITY(1,1) PRIMARY KEY,
                            CategoryName NVARCHAR(100) NOT NULL,
                            Description NVARCHAR(255),
                            CreatedDate DATETIME DEFAULT GETDATE()
                        )";

                    // Create Products table
                    string createProductsTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Products' AND xtype='U')
                        CREATE TABLE Products (
                            ProductId INT IDENTITY(1,1) PRIMARY KEY,
                            ProductName NVARCHAR(100) NOT NULL,
                            CategoryId INT,
                            Price DECIMAL(10,2) NOT NULL,
                            Stock INT DEFAULT 0,
                            Description NVARCHAR(255),
                            CreatedDate DATETIME DEFAULT GETDATE(),
                            FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
                        )";

                    // Create Orders table
                    string createOrdersTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Orders' AND xtype='U')
                        CREATE TABLE Orders (
                            OrderId INT IDENTITY(1,1) PRIMARY KEY,
                            InvoiceNo NVARCHAR(50) UNIQUE NOT NULL,
                            CustomerName NVARCHAR(100),
                            SellerName NVARCHAR(100),
                            OrderDate DATETIME DEFAULT GETDATE(),
                            TotalAmount DECIMAL(10,2),
                            Status NVARCHAR(20) DEFAULT 'Completed'
                        )";

                    // Create OrderDetails table
                    string createOrderDetailsTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='OrderDetails' AND xtype='U')
                        CREATE TABLE OrderDetails (
                            OrderDetailId INT IDENTITY(1,1) PRIMARY KEY,
                            OrderId INT,
                            ProductId INT,
                            ProductName NVARCHAR(100),
                            Quantity INT NOT NULL,
                            Price DECIMAL(10,2) NOT NULL,
                            Amount DECIMAL(10,2) NOT NULL,
                            FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
                            FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
                        )";

                    // Execute table creation scripts
                    ExecuteNonQuery(connection, createCategoriesTable);
                    ExecuteNonQuery(connection, createProductsTable);
                    ExecuteNonQuery(connection, createOrdersTable);
                    ExecuteNonQuery(connection, createOrderDetailsTable);

                    // Insert sample data if tables are empty
                    InsertSampleData(connection);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void ExecuteNonQuery(SqlConnection connection, string sql)
            {
            using (SqlCommand command = new SqlCommand(sql, connection))
                {
                command.ExecuteNonQuery();
                }
            }

        private void InsertSampleData(SqlConnection connection)
            {
            // Check if categories exist
            string checkCategories = "SELECT COUNT(*) FROM Categories";
            using (SqlCommand command = new SqlCommand(checkCategories, connection))
                {
                int categoryCount = (int)command.ExecuteScalar();
                if (categoryCount == 0)
                    {
                    // Insert sample categories
                    string insertCategories = @"
                        INSERT INTO Categories (CategoryName, Description) VALUES
                        ('testing3Beer', 'Various beer products'),
                        ('testing2Wine', 'Wine and alcoholic beverages'),
                        ('testing3333testing3', 'Soft drinks and beverages')";
                    ExecuteNonQuery(connection, insertCategories);

                    // Insert sample products
                    string insertProducts = @"
                        INSERT INTO Products (ProductName, CategoryId, Price, Stock) VALUES
                        ('Angkor Beer KH', 1, 1.50, 100),
                        ('ABC Beer KH', 1, 1.75, 150),
                        ('Cambodia Beer KH', 1, 2.00, 120),
                        ('Tiger Beer KH', 1, 2.25, 80),
                        ('Red Wine Premium', 2, 15.50, 50),
                        ('White Wine Classic', 2, 12.75, 60),
                        ('Champagne Special', 2, 25.00, 30),
                        ('Rose Wine Local', 2, 18.50, 40),
                        ('Hanuman Energy Drink', 3, 0.75, 200),
                        ('Coca Cola KH', 3, 0.50, 300),
                        ('Pepsi Cola KH', 3, 0.50, 250),
                        ('Orange Juice Fresh', 3, 1.25, 180)";
                    ExecuteNonQuery(connection, insertProducts);
                    }
                }
            }

        public List<string> GetCategories()
            {
            List<string> categories = new List<string>();
            try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    connection.Open();
                    string sql = "SELECT CategoryName FROM Categories ORDER BY CategoryName";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                        using (SqlDataReader reader = command.ExecuteReader())
                            {
                            while (reader.Read())
                                {
                                categories.Add(reader["CategoryName"].ToString());
                                }
                            }
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return categories;
            }

        public List<Product> GetProductsByCategory(string categoryName)
            {
            List<Product> products = new List<Product>();
            try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    connection.Open();
                    string sql = @"
                        SELECT p.ProductId, p.ProductName, p.Price 
                        FROM Products p 
                        INNER JOIN Categories c ON p.CategoryId = c.CategoryId 
                        WHERE c.CategoryName = @CategoryName 
                        ORDER BY p.ProductName";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                        command.Parameters.AddWithValue("@CategoryName", categoryName);
                        using (SqlDataReader reader = command.ExecuteReader())
                            {
                            while (reader.Read())
                                {
                                products.Add(new Product
                                    {
                                    Id = (int)reader["ProductId"],
                                    Name = reader["ProductName"].ToString(),
                                    Price = (decimal)reader["Price"]
                                    });
                                }
                            }
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Error loading products: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return products;
            }

        public bool SaveOrder(string invoiceNo, string customer, string seller, List<CartItem> cartItems, decimal totalAmount)
            {
            try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                        try
                            {
                            // Insert order
                            string insertOrder = @"
                                INSERT INTO Orders (InvoiceNo, CustomerName, SellerName, TotalAmount) 
                                VALUES (@InvoiceNo, @CustomerName, @SellerName, @TotalAmount);
                                SELECT SCOPE_IDENTITY();";

                            int orderId;
                            using (SqlCommand command = new SqlCommand(insertOrder, connection, transaction))
                                {
                                command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                                command.Parameters.AddWithValue("@CustomerName", customer);
                                command.Parameters.AddWithValue("@SellerName", seller);
                                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                                orderId = Convert.ToInt32(command.ExecuteScalar());
                                }

                            // Insert order details
                            foreach (var item in cartItems)
                                {
                                string insertOrderDetail = @"
                                    INSERT INTO OrderDetails (OrderId, ProductId, ProductName, Quantity, Price, Amount) 
                                    VALUES (@OrderId, @ProductId, @ProductName, @Quantity, @Price, @Amount)";

                                using (SqlCommand command = new SqlCommand(insertOrderDetail, connection, transaction))
                                    {
                                    command.Parameters.AddWithValue("@OrderId", orderId);
                                    command.Parameters.AddWithValue("@ProductId", item.ProductId);
                                    command.Parameters.AddWithValue("@ProductName", item.ProductName);
                                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                                    command.Parameters.AddWithValue("@Price", item.Price);
                                    command.Parameters.AddWithValue("@Amount", item.Amount);
                                    command.ExecuteNonQuery();
                                    }
                                }

                            transaction.Commit();
                            return true;
                            }
                        catch
                            {
                            transaction.Rollback();
                            throw;
                            }
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show($"Error saving order: {ex.Message}", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            }
        }
    }