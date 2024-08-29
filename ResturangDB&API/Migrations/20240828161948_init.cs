using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResturangDB_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableSeats = table.Column<int>(type: "int", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    FK_MenuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemID);
                    table.ForeignKey(
                        name: "FK_MenuItems_Menus_FK_MenuID",
                        column: x => x.FK_MenuID,
                        principalTable: "Menus",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_CustomerID = table.Column<int>(type: "int", nullable: false),
                    FK_TableID = table.Column<int>(type: "int", nullable: false),
                    AmountOfPeople = table.Column<int>(type: "int", nullable: false),
                    BookingDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_FK_CustomerID",
                        column: x => x.FK_CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Tables_FK_TableID",
                        column: x => x.FK_TableID,
                        principalTable: "Tables",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "lukas@hotmail.com", "Lukas", "1234567890" },
                    { 2, "emma@gmail.com", "Emma", "2345678901" },
                    { 3, "noah@yahoo.com", "Noah", "3456789012" },
                    { 4, "olivia@outlook.com", "Olivia", "4567890123" },
                    { 5, "liam@hotmail.com", "Liam", "5678901234" },
                    { 6, "ava@gmail.com", "Ava", "6789012345" },
                    { 7, "ethan@yahoo.com", "Ethan", "7890123456" },
                    { 8, "sophia@outlook.com", "Sophia", "8901234567" },
                    { 9, "james@hotmail.com", "James", "9012345678" },
                    { 10, "mia@gmail.com", "Mia", "0123456789" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "Name" },
                values: new object[,]
                {
                    { 1, "Main Menu" },
                    { 2, "Drink Menu" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableID", "IsAvailable", "TableNumber", "TableSeats" },
                values: new object[,]
                {
                    { 1, true, 1, 2 },
                    { 2, true, 2, 4 },
                    { 3, true, 3, 6 },
                    { 4, true, 4, 2 },
                    { 5, true, 5, 8 },
                    { 6, true, 6, 4 },
                    { 7, true, 7, 10 },
                    { 8, true, 8, 2 },
                    { 9, true, 9, 6 },
                    { 10, true, 10, 4 },
                    { 11, true, 11, 8 },
                    { 12, true, 12, 2 },
                    { 13, true, 13, 10 },
                    { 14, true, 14, 4 },
                    { 15, true, 15, 6 },
                    { 16, true, 16, 8 },
                    { 17, true, 17, 2 },
                    { 18, true, 18, 4 },
                    { 19, true, 19, 6 },
                    { 20, true, 20, 8 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemID", "FK_MenuID", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, true, "Bolognese", 130 },
                    { 2, 1, true, "Margherita Pizza", 120 },
                    { 3, 1, true, "Caesar Salad", 95 },
                    { 4, 1, true, "Grilled Chicken", 150 },
                    { 5, 1, true, "Fish Tacos", 110 },
                    { 6, 1, true, "BBQ Ribs", 200 },
                    { 7, 1, true, "Beef Stroganoff", 160 },
                    { 8, 1, true, "Vegetable Stir-Fry", 100 },
                    { 9, 1, true, "Spaghetti Carbonara", 135 },
                    { 10, 1, true, "Lasagna", 140 },
                    { 11, 1, true, "Chicken Alfredo", 145 },
                    { 12, 1, true, "Garlic Bread", 50 },
                    { 13, 1, true, "French Fries", 40 },
                    { 14, 1, true, "Cheeseburger", 110 },
                    { 15, 1, true, "Greek Salad", 85 },
                    { 16, 1, true, "Mushroom Risotto", 130 },
                    { 17, 1, true, "Tuna Sandwich", 75 },
                    { 18, 1, true, "Pancakes", 90 },
                    { 19, 1, true, "Chocolate Cake", 60 },
                    { 20, 1, true, "Ice Cream Sundae", 70 },
                    { 21, 2, true, "Coca-Cola", 25 },
                    { 22, 2, true, "Sprite", 25 },
                    { 23, 2, true, "Fanta", 25 },
                    { 24, 2, true, "Pepsi", 25 },
                    { 25, 2, true, "Iced Tea", 30 },
                    { 26, 2, true, "Lemonade", 30 },
                    { 27, 2, true, "Orange Juice", 35 },
                    { 28, 2, true, "Apple Juice", 35 },
                    { 29, 2, true, "Mineral Water", 20 },
                    { 30, 2, true, "Sparkling Water", 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FK_CustomerID",
                table: "Bookings",
                column: "FK_CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FK_TableID",
                table: "Bookings",
                column: "FK_TableID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_FK_MenuID",
                table: "MenuItems",
                column: "FK_MenuID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
