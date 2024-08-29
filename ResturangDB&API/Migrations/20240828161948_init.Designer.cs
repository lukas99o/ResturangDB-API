﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResturangDB_API.Data;

#nullable disable

namespace ResturangDB_API.Migrations
{
    [DbContext(typeof(ResturangContext))]
    [Migration("20240828161948_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ResturangDB_API.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("AmountOfPeople")
                        .HasColumnType("int");

                    b.Property<DateTime>("BookingDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookingTimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("FK_CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("FK_TableID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("FK_CustomerID");

                    b.HasIndex("FK_TableID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ResturangDB_API.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Email = "lukas@hotmail.com",
                            Name = "Lukas",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            CustomerID = 2,
                            Email = "emma@gmail.com",
                            Name = "Emma",
                            PhoneNumber = "2345678901"
                        },
                        new
                        {
                            CustomerID = 3,
                            Email = "noah@yahoo.com",
                            Name = "Noah",
                            PhoneNumber = "3456789012"
                        },
                        new
                        {
                            CustomerID = 4,
                            Email = "olivia@outlook.com",
                            Name = "Olivia",
                            PhoneNumber = "4567890123"
                        },
                        new
                        {
                            CustomerID = 5,
                            Email = "liam@hotmail.com",
                            Name = "Liam",
                            PhoneNumber = "5678901234"
                        },
                        new
                        {
                            CustomerID = 6,
                            Email = "ava@gmail.com",
                            Name = "Ava",
                            PhoneNumber = "6789012345"
                        },
                        new
                        {
                            CustomerID = 7,
                            Email = "ethan@yahoo.com",
                            Name = "Ethan",
                            PhoneNumber = "7890123456"
                        },
                        new
                        {
                            CustomerID = 8,
                            Email = "sophia@outlook.com",
                            Name = "Sophia",
                            PhoneNumber = "8901234567"
                        },
                        new
                        {
                            CustomerID = 9,
                            Email = "james@hotmail.com",
                            Name = "James",
                            PhoneNumber = "9012345678"
                        },
                        new
                        {
                            CustomerID = 10,
                            Email = "mia@gmail.com",
                            Name = "Mia",
                            PhoneNumber = "0123456789"
                        });
                });

            modelBuilder.Entity("ResturangDB_API.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            Name = "Main Menu"
                        },
                        new
                        {
                            MenuID = 2,
                            Name = "Drink Menu"
                        });
                });

            modelBuilder.Entity("ResturangDB_API.Models.MenuItem", b =>
                {
                    b.Property<int>("MenuItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemID"));

                    b.Property<int>("FK_MenuID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("MenuItemID");

                    b.HasIndex("FK_MenuID");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemID = 1,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Bolognese",
                            Price = 130
                        },
                        new
                        {
                            MenuItemID = 2,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Margherita Pizza",
                            Price = 120
                        },
                        new
                        {
                            MenuItemID = 3,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Caesar Salad",
                            Price = 95
                        },
                        new
                        {
                            MenuItemID = 4,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Grilled Chicken",
                            Price = 150
                        },
                        new
                        {
                            MenuItemID = 5,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Fish Tacos",
                            Price = 110
                        },
                        new
                        {
                            MenuItemID = 6,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "BBQ Ribs",
                            Price = 200
                        },
                        new
                        {
                            MenuItemID = 7,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Beef Stroganoff",
                            Price = 160
                        },
                        new
                        {
                            MenuItemID = 8,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Vegetable Stir-Fry",
                            Price = 100
                        },
                        new
                        {
                            MenuItemID = 9,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Spaghetti Carbonara",
                            Price = 135
                        },
                        new
                        {
                            MenuItemID = 10,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Lasagna",
                            Price = 140
                        },
                        new
                        {
                            MenuItemID = 11,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Chicken Alfredo",
                            Price = 145
                        },
                        new
                        {
                            MenuItemID = 12,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Garlic Bread",
                            Price = 50
                        },
                        new
                        {
                            MenuItemID = 13,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "French Fries",
                            Price = 40
                        },
                        new
                        {
                            MenuItemID = 14,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Cheeseburger",
                            Price = 110
                        },
                        new
                        {
                            MenuItemID = 15,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Greek Salad",
                            Price = 85
                        },
                        new
                        {
                            MenuItemID = 16,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Mushroom Risotto",
                            Price = 130
                        },
                        new
                        {
                            MenuItemID = 17,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Tuna Sandwich",
                            Price = 75
                        },
                        new
                        {
                            MenuItemID = 18,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Pancakes",
                            Price = 90
                        },
                        new
                        {
                            MenuItemID = 19,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Chocolate Cake",
                            Price = 60
                        },
                        new
                        {
                            MenuItemID = 20,
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Ice Cream Sundae",
                            Price = 70
                        },
                        new
                        {
                            MenuItemID = 21,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Coca-Cola",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 22,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Sprite",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 23,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Fanta",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 24,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Pepsi",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 25,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Iced Tea",
                            Price = 30
                        },
                        new
                        {
                            MenuItemID = 26,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Lemonade",
                            Price = 30
                        },
                        new
                        {
                            MenuItemID = 27,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Orange Juice",
                            Price = 35
                        },
                        new
                        {
                            MenuItemID = 28,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Apple Juice",
                            Price = 35
                        },
                        new
                        {
                            MenuItemID = 29,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Mineral Water",
                            Price = 20
                        },
                        new
                        {
                            MenuItemID = 30,
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Sparkling Water",
                            Price = 25
                        });
                });

            modelBuilder.Entity("ResturangDB_API.Models.Table", b =>
                {
                    b.Property<int>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableID"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<int>("TableSeats")
                        .HasColumnType("int");

                    b.HasKey("TableID");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableID = 1,
                            IsAvailable = true,
                            TableNumber = 1,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 2,
                            IsAvailable = true,
                            TableNumber = 2,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 3,
                            IsAvailable = true,
                            TableNumber = 3,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 4,
                            IsAvailable = true,
                            TableNumber = 4,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 5,
                            IsAvailable = true,
                            TableNumber = 5,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 6,
                            IsAvailable = true,
                            TableNumber = 6,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 7,
                            IsAvailable = true,
                            TableNumber = 7,
                            TableSeats = 10
                        },
                        new
                        {
                            TableID = 8,
                            IsAvailable = true,
                            TableNumber = 8,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 9,
                            IsAvailable = true,
                            TableNumber = 9,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 10,
                            IsAvailable = true,
                            TableNumber = 10,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 11,
                            IsAvailable = true,
                            TableNumber = 11,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 12,
                            IsAvailable = true,
                            TableNumber = 12,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 13,
                            IsAvailable = true,
                            TableNumber = 13,
                            TableSeats = 10
                        },
                        new
                        {
                            TableID = 14,
                            IsAvailable = true,
                            TableNumber = 14,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 15,
                            IsAvailable = true,
                            TableNumber = 15,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 16,
                            IsAvailable = true,
                            TableNumber = 16,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 17,
                            IsAvailable = true,
                            TableNumber = 17,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 18,
                            IsAvailable = true,
                            TableNumber = 18,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 19,
                            IsAvailable = true,
                            TableNumber = 19,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 20,
                            IsAvailable = true,
                            TableNumber = 20,
                            TableSeats = 8
                        });
                });

            modelBuilder.Entity("ResturangDB_API.Models.Booking", b =>
                {
                    b.HasOne("ResturangDB_API.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("FK_CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResturangDB_API.Models.Table", "Table")
                        .WithMany("Bookings")
                        .HasForeignKey("FK_TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("ResturangDB_API.Models.MenuItem", b =>
                {
                    b.HasOne("ResturangDB_API.Models.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("FK_MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("ResturangDB_API.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ResturangDB_API.Models.Menu", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("ResturangDB_API.Models.Table", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}