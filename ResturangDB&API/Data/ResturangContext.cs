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
                    new Table { TableID = 1, TableNumber = 1, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 2, TableNumber = 2, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 3, TableNumber = 3, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 4, TableNumber = 4, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 5, TableNumber = 5, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 6, TableNumber = 6, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 7, TableNumber = 7, TableSeats = 10, IsAvailable = true },
                    new Table { TableID = 8, TableNumber = 8, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 9, TableNumber = 9, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 10, TableNumber = 10, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 11, TableNumber = 11, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 12, TableNumber = 12, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 13, TableNumber = 13, TableSeats = 10, IsAvailable = true },
                    new Table { TableID = 14, TableNumber = 14, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 15, TableNumber = 15, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 16, TableNumber = 16, TableSeats = 8, IsAvailable = true },
                    new Table { TableID = 17, TableNumber = 17, TableSeats = 2, IsAvailable = true },
                    new Table { TableID = 18, TableNumber = 18, TableSeats = 4, IsAvailable = true },
                    new Table { TableID = 19, TableNumber = 19, TableSeats = 6, IsAvailable = true },
                    new Table { TableID = 20, TableNumber = 20, TableSeats = 8, IsAvailable = true }
                );

            modelBuilder.Entity<Menu>().HasData
                (
                    new Menu { MenuID = 1, Name = "Main Menu" },
                    new Menu { MenuID = 2, Name = "Drink Menu" }
                );
        }
    }
}
