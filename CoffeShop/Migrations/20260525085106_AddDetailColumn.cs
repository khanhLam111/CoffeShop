using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeShop.Migrations
{
    /// <inheritdoc />
    public partial class AddDetailColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct", "Name" },
                values: new object[] { "", "https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=815", true, "Black Diamond Coffee" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[] { "", "https://images.unsplash.com/photo-1498804103079-a6351b050096?w=815", true, "The Roasted Bean", 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[] { "", "https://images.unsplash.com/photo-1447933601403-0c6688de566e?w=815", true, "Beanery Espresso", 45m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "", "https://images.unsplash.com/photo-1514432324607-a09d9b4aefdd?w=815", false, "Americano", 25m },
                    { 5, "", "https://images.unsplash.com/photo-1572442388796-11668a67e53d?w=815", false, "Mocha", 35m },
                    { 6, "", "https://images.unsplash.com/photo-1510707577719-ae7c14805e3a?w=815", false, "French Press", 55m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "IsTrendingProduct", "Name" },
                values: new object[] { "https://link-anh-1.jpg", false, "America" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[] { "https://link-anh-2.jpg", false, "Vietnam", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[] { "https://link-anh-3.jpg", false, "United Kingdom", 15m });
        }
    }
}
