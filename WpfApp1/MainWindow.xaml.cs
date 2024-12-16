using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Populate the DataGrid with sample data
            ProductGrid.ItemsSource = GetSampleData();
        }

        // Menu Item Click Event Handlers
        private void MenuItem_Manage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Manage Module...", "Manage", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Customer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Customer Module...", "Customer", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Saller_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Saller Module...", "Saller", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Supplier_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Supplier Module...", "Supplier", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Product_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Product Module...", "Product", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Purchase_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Purchase Module...", "Purchase", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Expanse_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Expanse Module...", "Expanse", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Service_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Service Module...", "Service", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Banking_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Banking Module...", "Banking", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Reports_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Reports Module...", "Reports", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Salary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Salary Module...", "Salary", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Recovery_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Recovery Module...", "Recovery", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Setting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Setting Module...", "Setting", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Tool_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Tool Module...", "Tool", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("POS System Application\nVersion: 1.0\nDeveloper: Your Name", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MenuItem_Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Toolbar Button Click Event Handlers
        private void Toolbar_Register_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Register Module...", "Register", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Customer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Customer Module...", "Customer", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Saller_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Saller Module...", "Saller", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Supplier_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Supplier Module...", "Supplier", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Product_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Product Module...", "Product", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Purchase_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Purchase Module...", "Purchase", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Expanse_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Expanse Module...", "Expanse", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Stock_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Stock Module...", "Stock", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Service_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Service Module...", "Service", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_SupplierPayment_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Supplier Payment Module...", "Supplier Payment", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Quotation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Quotation Module...", "Quotation", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Database_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Database Module...", "Database", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Setting_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Setting Module...", "Setting", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Help Module...", "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Toolbar_Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging out...", "Logout", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Close Button Click Event Handler
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Close the application
        }

        // Generate 100 sample records
        private List<Product> GetSampleData()
        {
            var products = new List<Product>();
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    No = i,
                    ProductName = $"Product {i}",
                    Category = $"Category {i % 5 + 1}",
                    Barcode = $"12345678{i:000}",
                    CostPrice = 10.0 + i,
                    SellingPrice = 15.0 + i,
                    Discount = i % 10 == 0 ? 5.0 : 0.0,
                    Quantity = i * 2,
                    Stock = i * 5,
                    Unit = "pcs",
                    Status = i % 2 == 0 ? "Available" : "Out of Stock"
                });
            }
            return products;
        }
    }

    // Product class for DataGrid binding
    public class Product
    {
        public int No { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Barcode { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public string Unit { get; set; }
        public string Status { get; set; }
    }
}
