using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDatabaseApp
    {
    public partial class SaleForm : Form
        {
        // Sample data structures
        private Dictionary<string, List<Product>> categoryProducts;
        private List<CartItem> cartItems;
        private DatabaseManager dbManager;
        private bool useDatabase = false;

        public SaleForm()
            {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeData();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            LoadComboBoxData();
            GenerateInvoiceNumber();
            SetCurrentDateTime();
            LoadCategoriesToListBox();
            }

        private void LoadCategoriesToListBox()
            {
            if (useDatabase)
                {
                var categories = dbManager.GetCategories();
                lstCategory.Items.Clear();
                foreach (var category in categories)
                    {
                    lstCategory.Items.Add(category);
                    }
                }
            // If not using database, categories are already loaded from sample data
            }

        private void InitializeDatabaseConnection()
            {
            try
                {
                dbManager = new DatabaseManager();
                if (dbManager.TestConnection())
                    {
                    dbManager.InitializeDatabase();
                    useDatabase = true;
                    MessageBox.Show("Database connected successfully!", "Database Status",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                else
                    {
                    useDatabase = false;
                    MessageBox.Show("Database connection failed. Using sample data.", "Database Status",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            catch (Exception ex)
                {
                useDatabase = false;
                MessageBox.Show($"Database initialization error: {ex.Message}\nUsing sample data.", "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void InitializeData()
            {
            // Initialize sample product data
            categoryProducts = new Dictionary<string, List<Product>>
                {
                ["testing3Beer"] = new List<Product>
                {
                    new Product { Id = 1, Name = "Angkor Beer KH", Price = 1.50m },
                    new Product { Id = 2, Name = "ABC Beer KH", Price = 1.75m },
                    new Product { Id = 3, Name = "Cambodia Beer KH", Price = 2.00m },
                    new Product { Id = 4, Name = "Tiger Beer KH", Price = 2.25m }
                },
                ["testing2Wine"] = new List<Product>
                {
                    new Product { Id = 5, Name = "Red Wine Premium", Price = 15.50m },
                    new Product { Id = 6, Name = "White Wine Classic", Price = 12.75m },
                    new Product { Id = 7, Name = "Champagne Special", Price = 25.00m },
                    new Product { Id = 8, Name = "Rose Wine Local", Price = 18.50m }
                },
                ["testing3333testing3"] = new List<Product>
                {
                    new Product { Id = 9, Name = "Hanuman Energy Drink", Price = 0.75m },
                    new Product { Id = 10, Name = "Coca Cola KH", Price = 0.50m },
                    new Product { Id = 11, Name = "Pepsi Cola KH", Price = 0.50m },
                    new Product { Id = 12, Name = "Orange Juice Fresh", Price = 1.25m }
                }
                };

            cartItems = new List<CartItem>();
            }

        private void LoadComboBoxData()
            {
            // Load customer data
            cmbCustomer.Items.AddRange(new string[] { "Walk-in", "Regular Customer", "VIP Member", "Corporate" });
            cmbCustomer.SelectedIndex = 0;

            // Load seller data
            cmbSeller.Items.AddRange(new string[] { "aPhik.seng", "John.smith", "Mary.chan", "David.kim" });
            cmbSeller.SelectedIndex = 0;

            // Load date options
            cmbOrderDate.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            cmbOrderDate.SelectedIndex = 0;
            }

        private void GenerateInvoiceNumber()
            {
            // Generate invoice number based on current date and time
            string invoiceNo = DateTime.Now.ToString("yyyyMMddHHmmss");
            txtInvoiceNo.Text = invoiceNo;
            }

        private void SetCurrentDateTime()
            {
            cmbOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (lstCategory.SelectedItem != null)
                {
                string selectedCategory = lstCategory.SelectedItem.ToString();
                LoadProductList(selectedCategory);
                }
            }

        private void LoadProductList(string category)
            {
            dgvProductList.Rows.Clear();

            if (useDatabase)
                {
                var products = dbManager.GetProductsByCategory(category);
                foreach (var product in products)
                    {
                    dgvProductList.Rows.Add(product.Id, product.Name);
                    }
                }
            else
                {
                // Use sample data
                if (categoryProducts.ContainsKey(category))
                    {
                    foreach (var product in categoryProducts[category])
                        {
                        dgvProductList.Rows.Add(product.Id, product.Name);
                        }
                    }
                }
            }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
                {
                int productId = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells["colProductId"].Value);
                string productName = dgvProductList.Rows[e.RowIndex].Cells["colProductName"].Value.ToString();

                AddToCart(productId, productName);
                }
            }

        private void AddToCart(int productId, string productName)
            {
            // Find the product to get its price
            Product product = null;

            if (useDatabase)
                {
                // Get product from current loaded products in the DataGridView
                // This is a simple approach; alternatively, you could query the database directly
                var selectedCategory = lstCategory.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(selectedCategory))
                    {
                    var products = dbManager.GetProductsByCategory(selectedCategory);
                    product = products.FirstOrDefault(p => p.Id == productId);
                    }
                }
            else
                {
                // Use sample data
                foreach (var categoryList in categoryProducts.Values)
                    {
                    product = categoryList.FirstOrDefault(p => p.Id == productId);
                    if (product != null) break;
                    }
                }

            if (product == null) return;

            // Check if item already exists in cart
            var existingCartItem = cartItems.FirstOrDefault(c => c.ProductId == productId);
            if (existingCartItem != null)
                {
                existingCartItem.Quantity++;
                existingCartItem.Amount = existingCartItem.Quantity * existingCartItem.Price;
                RefreshCartDisplay();
                }
            else
                {
                // Add new item to cart
                var cartItem = new CartItem
                    {
                    ProductId = productId,
                    ProductName = productName,
                    Quantity = 1,
                    Price = product.Price,
                    Amount = product.Price
                    };
                cartItems.Add(cartItem);

                // Add to DataGridView
                dgvCart.Rows.Add(productName, 1, product.Price.ToString("F2"), product.Price.ToString("F2"));
                }

            CalculateTotals();
            }

        private void RefreshCartDisplay()
            {
            dgvCart.Rows.Clear();
            foreach (var item in cartItems)
                {
                dgvCart.Rows.Add(item.ProductName, item.Quantity, item.Price.ToString("F2"), item.Amount.ToString("F2"));
                }
            }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2)) // Qty or Price column
                {
                try
                    {
                    var row = dgvCart.Rows[e.RowIndex];
                    int qty = Convert.ToInt32(row.Cells["colCartQty"].Value ?? 0);
                    decimal price = Convert.ToDecimal(row.Cells["colCartPrice"].Value ?? 0);
                    decimal amount = qty * price;

                    row.Cells["colCartAmount"].Value = amount.ToString("F2");

                    // Update cartItems list
                    if (e.RowIndex < cartItems.Count)
                        {
                        cartItems[e.RowIndex].Quantity = qty;
                        cartItems[e.RowIndex].Price = price;
                        cartItems[e.RowIndex].Amount = amount;
                        }

                    CalculateTotals();
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show("Please enter valid numbers for quantity and price.", "Invalid Input",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        private void dgvCart_KeyDown(object sender, KeyEventArgs e)
            {
            // Allow Delete key to remove selected item from cart
            if (e.KeyCode == Keys.Delete && dgvCart.SelectedRows.Count > 0)
                {
                int selectedIndex = dgvCart.SelectedRows[0].Index;
                if (selectedIndex < cartItems.Count)
                    {
                    cartItems.RemoveAt(selectedIndex);
                    dgvCart.Rows.RemoveAt(selectedIndex);
                    CalculateTotals();
                    }
                }
            }

        private void CalculateTotals()
            {
            int totalQty = cartItems.Sum(c => c.Quantity);
            decimal totalPrice = cartItems.Sum(c => c.Price);
            decimal totalAmount = cartItems.Sum(c => c.Amount);

            txtTotalQty.Text = totalQty.ToString();
            txtTotalPrice.Text = totalPrice.ToString("F2");
            txtTotalAmount.Text = totalAmount.ToString("F2");
            }

        private void btnOrder_Click(object sender, EventArgs e)
            {
            if (cartItems.Count == 0)
                {
                MessageBox.Show("Please add items to cart before placing order.", "Empty Cart",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                }

            // Simulate order processing
            string orderSummary = $"Order #{txtInvoiceNo.Text}\n";
            orderSummary += $"Customer: {cmbCustomer.Text}\n";
            orderSummary += $"Seller: {cmbSeller.Text}\n";
            orderSummary += $"Date: {cmbOrderDate.Text}\n\n";
            orderSummary += "Items:\n";

            foreach (var item in cartItems)
                {
                orderSummary += $"- {item.ProductName} x{item.Quantity} = ${item.Amount:F2}\n";
                }

            orderSummary += $"\nTotal Amount: ${txtTotalAmount.Text}";

            DialogResult result = MessageBox.Show(orderSummary + "\n\nConfirm this order?", "Order Confirmation",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                {
                bool orderSaved = true;

                // Save to database if available
                if (useDatabase)
                    {
                    decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
                    orderSaved = dbManager.SaveOrder(txtInvoiceNo.Text, cmbCustomer.Text,
                                                   cmbSeller.Text, cartItems, totalAmount);
                    }

                if (orderSaved)
                    {
                    string successMessage = "Order placed successfully!";
                    if (useDatabase)
                        successMessage += "\nOrder has been saved to database.";
                    else
                        successMessage += "\nNote: Order not saved (database not available).";

                    MessageBox.Show(successMessage, "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(sender, e); // Clear the form
                    }
                else
                    {
                    MessageBox.Show("Order could not be saved to database. Please try again.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void btnReset_Click(object sender, EventArgs e)
            {
            // Clear cart
            cartItems.Clear();
            dgvCart.Rows.Clear();

            // Reset totals
            txtTotalQty.Text = "0";
            txtTotalPrice.Text = "0.00";
            txtTotalAmount.Text = "0.00";

            // Clear product list
            dgvProductList.Rows.Clear();

            // Reset selections
            lstCategory.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = 0;
            cmbSeller.SelectedIndex = 0;

            // Generate new invoice number
            GenerateInvoiceNumber();
            SetCurrentDateTime();

            // Reload categories if using database
            if (useDatabase)
                {
                LoadCategoriesToListBox();
                }

            MessageBox.Show("Form has been reset.", "Reset Complete",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    // Helper classes for data structure
    public class Product
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        }

    public class CartItem
        {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        }
    }