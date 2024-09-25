using Microsoft.EntityFrameworkCore;
using ResturangDB_API.Models;

namespace ResturangDB_API.Data
{
    public class ResturangContext : DbContext
    {
        public ResturangContext(DbContextOptions<ResturangContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData
                (
                    new Customer { CustomerID = 1, Name = "Lukas", Email = "lukas@hotmail.com", PhoneNumber = "1234567890" },
                    new Customer { CustomerID = 2, Name = "Emma", Email = "emma@gmail.com", PhoneNumber = "2345678901" },
                    new Customer { CustomerID = 3, Name = "Noah", Email = "noah@yahoo.com", PhoneNumber = "3456789012" },
                    new Customer { CustomerID = 4, Name = "Olivia", Email = "olivia@outlook.com", PhoneNumber = "4567890123" },
                    new Customer { CustomerID = 5, Name = "Liam", Email = "liam@hotmail.com", PhoneNumber = "5678901234" },
                    new Customer { CustomerID = 6, Name = "Ava", Email = "ava@gmail.com", PhoneNumber = "6789012345" },
                    new Customer { CustomerID = 7, Name = "Ethan", Email = "ethan@yahoo.com", PhoneNumber = "7890123456" },
                    new Customer { CustomerID = 8, Name = "Sophia", Email = "sophia@outlook.com", PhoneNumber = "8901234567" },
                    new Customer { CustomerID = 9, Name = "James", Email = "james@hotmail.com", PhoneNumber = "9012345678" },
                    new Customer { CustomerID = 10, Name = "Mia", Email = "mia@gmail.com", PhoneNumber = "0123456789" }
                );

            modelBuilder.Entity<Table>().HasData
                (
                    new Table { TableID = 1, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 2, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 3, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 4, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 5, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 6, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 7, TableSeats = 10, IsAvailable = true },
                    new Table { TableID = 8, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 9, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 10, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 11, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 12, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 13, TableSeats = 10, IsAvailable = true },
                    new Table { TableID = 14, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 15, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 16, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 17, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 18, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 19, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 20, TableSeats = 8, IsAvailable = true }
                );

            modelBuilder.Entity<Menu>().HasData
                (
                    new Menu { MenuID = 1, Name = "Main Menu" },
                    new Menu { MenuID = 2, Name = "Drink Menu" }
                );

            modelBuilder.Entity<MenuItem>().HasData
                (
                    // Main Menu
                    new MenuItem { MenuItemID = 1, Name = "Bolognese", Price = 130, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 2, Name = "Margherita Pizza", Price = 120, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 3, Name = "Caesar Salad", Price = 95, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 4, Name = "Grilled Chicken", Price = 150, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 5, Name = "Fish Tacos", Price = 110, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 6, Name = "BBQ Ribs", Price = 200, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 7, Name = "Beef Stroganoff", Price = 160, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 8, Name = "Vegetable Stir-Fry", Price = 100, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 9, Name = "Spaghetti Carbonara", Price = 135, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 10, Name = "Lasagna", Price = 140, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 11, Name = "Chicken Alfredo", Price = 145, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 12, Name = "Garlic Bread", Price = 50, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 13, Name = "French Fries", Price = 40, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 14, Name = "Cheeseburger", Price = 110, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 15, Name = "Greek Salad", Price = 85, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 16, Name = "Mushroom Risotto", Price = 130, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 17, Name = "Tuna Sandwich", Price = 75, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 18, Name = "Pancakes", Price = 90, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 19, Name = "Chocolate Cake", Price = 60, IsAvailable = true, FK_MenuID = 1 },
                    new MenuItem { MenuItemID = 20, Name = "Ice Cream Sundae", Price = 70, IsAvailable = true, FK_MenuID = 1 },
                    // Drink Menu
                    new MenuItem { MenuItemID = 21, Name = "Coca-Cola", Price = 25, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 22, Name = "Sprite", Price = 25, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 23, Name = "Fanta", Price = 25, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 24, Name = "Pepsi", Price = 25, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 25, Name = "Iced Tea", Price = 30, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 26, Name = "Lemonade", Price = 30, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 27, Name = "Orange Juice", Price = 35, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 28, Name = "Apple Juice", Price = 35, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 29, Name = "Mineral Water", Price = 20, IsAvailable = true, FK_MenuID = 2 },
                    new MenuItem { MenuItemID = 30, Name = "Sparkling Water", Price = 25, IsAvailable = true, FK_MenuID = 2 }
                );
        }
    }
}
