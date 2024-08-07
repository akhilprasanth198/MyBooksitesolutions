using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBooksite.Migrations
{
    /// <inheritdoc />
    public partial class migrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Title", "age", "authorid", "language", "price", "publishedyear", "subject" },
                values: new object[] { 1, "Alchemist", 55, 1, "english", 800, 2011, "novel" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
