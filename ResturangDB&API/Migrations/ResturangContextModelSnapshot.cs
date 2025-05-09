﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResturangDB_API.Data;

#nullable disable

namespace ResturangDB_API.Migrations
{
    [DbContext(typeof(ResturangContext))]
    partial class ResturangContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("FK_CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("FK_TableID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
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
                        },
                        new
                        {
                            CustomerID = 11,
                            Email = "admin@email.com",
                            Password = "admin"
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_MenuID")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

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
                            Description = "Classic Italian pasta with a rich, meaty tomato sauce.",
                            FK_MenuID = 1,
                            ImgUrl = "https://www.recipetineats.com/tachyon/2018/07/Spaghetti-Bolognese.jpg",
                            IsAvailable = true,
                            Name = "Bolognese",
                            Price = 130
                        },
                        new
                        {
                            MenuItemID = 2,
                            Description = "Fresh pizza topped with mozzarella, basil, and tomato sauce.",
                            FK_MenuID = 1,
                            ImgUrl = "https://eu-central-1.linodeobjects.com/tasteline/2018/06/pizza-margherita-foto-kerstin-eriksson-original-2048x2048.jpg",
                            IsAvailable = true,
                            Name = "Margherita Pizza",
                            Price = 120
                        },
                        new
                        {
                            MenuItemID = 3,
                            Description = "Crisp romaine lettuce with Caesar dressing, croutons, and Parmesan.",
                            FK_MenuID = 1,
                            ImgUrl = "https://cdn.kronfagel.se/app/uploads/2019/07/Caesarsallad.jpg",
                            IsAvailable = true,
                            Name = "Caesar Salad",
                            Price = 95
                        },
                        new
                        {
                            MenuItemID = 4,
                            Description = "Juicy grilled chicken marinated in flavorful herbs and spices.",
                            FK_MenuID = 1,
                            ImgUrl = "https://www.cookinwithmima.com/wp-content/uploads/2021/06/Grilled-BBQ-Chicken.jpg",
                            IsAvailable = true,
                            Name = "Grilled Chicken",
                            Price = 150
                        },
                        new
                        {
                            MenuItemID = 5,
                            Description = "Soft tacos filled with crispy fried fish and zesty slaw.",
                            FK_MenuID = 1,
                            ImgUrl = "https://www.allrecipes.com/thmb/_emMPu4gpcuCOoC0kfjRWIdHlmc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/53729-fish-tacos-DDMFS-4x3-b5547c67c6f0432da06ad8f905e82c1e.jpg",
                            IsAvailable = true,
                            Name = "Fish Tacos",
                            Price = 110
                        },
                        new
                        {
                            MenuItemID = 6,
                            Description = "Tender pork ribs glazed with smoky BBQ sauce, grilled to perfection.",
                            FK_MenuID = 1,
                            ImgUrl = "https://www.barossafinefoods.com.au/glide-cache/containers/main/2020_bff_porkribs_bbq_website-2.jpg/03d880f2ca84b83fdeb147548e7d9b12.jpg",
                            IsAvailable = true,
                            Name = "BBQ Ribs",
                            Price = 200
                        },
                        new
                        {
                            MenuItemID = 7,
                            Description = "Creamy beef stroganoff served with sautéed mushrooms and pasta.",
                            FK_MenuID = 1,
                            ImgUrl = "https://www.recipetineats.com/tachyon/2018/01/Beef-Stroganoff_2-1-1.jpg",
                            IsAvailable = true,
                            Name = "Beef Stroganoff",
                            Price = 160
                        },
                        new
                        {
                            MenuItemID = 8,
                            Description = "Fresh veggies stir-fried in a light soy sauce with ginger and garlic.",
                            FK_MenuID = 1,
                            ImgUrl = "https://natashaskitchen.com/wp-content/uploads/2020/08/Vegetable-Stir-Fry-2.jpg",
                            IsAvailable = true,
                            Name = "Vegetable Stir-Fry",
                            Price = 100
                        },
                        new
                        {
                            MenuItemID = 9,
                            Description = "Classic Italian pasta with creamy egg sauce, pancetta, and Parmesan.",
                            FK_MenuID = 1,
                            ImgUrl = "https://static01.nyt.com/images/2021/02/14/dining/carbonara-horizontal/carbonara-horizontal-square640-v2.jpg",
                            IsAvailable = true,
                            Name = "Spaghetti Carbonara",
                            Price = 135
                        },
                        new
                        {
                            MenuItemID = 10,
                            Description = "Layers of pasta, meat sauce, and cheese baked to golden perfection.",
                            FK_MenuID = 1,
                            ImgUrl = "https://thecozycook.com/wp-content/uploads/2022/04/Lasagna-Recipe-f.jpg",
                            IsAvailable = true,
                            Name = "Lasagna",
                            Price = 140
                        },
                        new
                        {
                            MenuItemID = 11,
                            Description = "Rich and creamy Alfredo sauce tossed with tender grilled chicken and pasta.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Chicken Alfredo",
                            Price = 145
                        },
                        new
                        {
                            MenuItemID = 12,
                            Description = "Crispy bread slices toasted with garlic butter and fresh herbs.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Garlic Bread",
                            Price = 50
                        },
                        new
                        {
                            MenuItemID = 13,
                            Description = "Golden and crispy fries seasoned to perfection.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "French Fries",
                            Price = 40
                        },
                        new
                        {
                            MenuItemID = 14,
                            Description = "Juicy beef patty topped with melted cheese, lettuce, and tomato.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Cheeseburger",
                            Price = 110
                        },
                        new
                        {
                            MenuItemID = 15,
                            Description = "Fresh veggies, feta cheese, and olives tossed in a light vinaigrette.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Greek Salad",
                            Price = 85
                        },
                        new
                        {
                            MenuItemID = 16,
                            Description = "Creamy Arborio rice cooked with sautéed mushrooms and Parmesan.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Mushroom Risotto",
                            Price = 130
                        },
                        new
                        {
                            MenuItemID = 17,
                            Description = "Classic tuna salad sandwich served on toasted bread.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Tuna Sandwich",
                            Price = 75
                        },
                        new
                        {
                            MenuItemID = 18,
                            Description = "Fluffy pancakes served with syrup and butter.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Pancakes",
                            Price = 90
                        },
                        new
                        {
                            MenuItemID = 19,
                            Description = "Decadent chocolate cake topped with rich frosting.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Chocolate Cake",
                            Price = 60
                        },
                        new
                        {
                            MenuItemID = 20,
                            Description = "Creamy ice cream topped with chocolate sauce, nuts, and a cherry.",
                            FK_MenuID = 1,
                            IsAvailable = true,
                            Name = "Ice Cream Sundae",
                            Price = 70
                        },
                        new
                        {
                            MenuItemID = 21,
                            Description = "Refreshing carbonated soft drink.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Coca-Cola",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 22,
                            Description = "Crisp lemon-lime flavored soda.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Sprite",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 23,
                            Description = "Fruity and sweet orange soda.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Fanta",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 24,
                            Description = "Classic cola with a bold, refreshing taste.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Pepsi",
                            Price = 25
                        },
                        new
                        {
                            MenuItemID = 25,
                            Description = "Chilled tea served with lemon for a refreshing taste.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Iced Tea",
                            Price = 30
                        },
                        new
                        {
                            MenuItemID = 26,
                            Description = "Freshly squeezed lemonade with a tangy, sweet flavor.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Lemonade",
                            Price = 30
                        },
                        new
                        {
                            MenuItemID = 27,
                            Description = "Freshly squeezed orange juice, packed with vitamin C.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Orange Juice",
                            Price = 35
                        },
                        new
                        {
                            MenuItemID = 28,
                            Description = "Crisp and sweet apple juice.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Apple Juice",
                            Price = 35
                        },
                        new
                        {
                            MenuItemID = 29,
                            Description = "Refreshing and clean mineral water.",
                            FK_MenuID = 2,
                            IsAvailable = true,
                            Name = "Mineral Water",
                            Price = 20
                        },
                        new
                        {
                            MenuItemID = 30,
                            Description = "Bubbly, refreshing sparkling water.",
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

                    b.Property<int>("TableSeats")
                        .HasColumnType("int");

                    b.HasKey("TableID");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableID = 1,
                            IsAvailable = true,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 2,
                            IsAvailable = true,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 3,
                            IsAvailable = true,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 4,
                            IsAvailable = true,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 5,
                            IsAvailable = true,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 6,
                            IsAvailable = true,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 7,
                            IsAvailable = true,
                            TableSeats = 10
                        },
                        new
                        {
                            TableID = 8,
                            IsAvailable = true,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 9,
                            IsAvailable = true,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 10,
                            IsAvailable = true,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 11,
                            IsAvailable = true,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 12,
                            IsAvailable = true,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 13,
                            IsAvailable = true,
                            TableSeats = 10
                        },
                        new
                        {
                            TableID = 14,
                            IsAvailable = true,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 15,
                            IsAvailable = true,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 16,
                            IsAvailable = true,
                            TableSeats = 8
                        },
                        new
                        {
                            TableID = 17,
                            IsAvailable = true,
                            TableSeats = 2
                        },
                        new
                        {
                            TableID = 18,
                            IsAvailable = true,
                            TableSeats = 4
                        },
                        new
                        {
                            TableID = 19,
                            IsAvailable = true,
                            TableSeats = 6
                        },
                        new
                        {
                            TableID = 20,
                            IsAvailable = true,
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
