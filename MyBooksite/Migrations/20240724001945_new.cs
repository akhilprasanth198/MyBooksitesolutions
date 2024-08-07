using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyBooksite.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name", "country", "primarynumber" },
                values: new object[] { 2, "shakespeare", "England", 987654321 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Title", "age", "authorid", "language", "price", "publishedyear", "subject" },
                values: new object[] { 2, "Hamlet", 55, 2, "english", 800, 2011, "novel" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name", "country", "primarynumber" },
                values: new object[] { 1, "shakespeare", "England", 987654321 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Title", "age", "authorid", "language", "price", "publishedyear", "subject" },
                values: new object[] { 1, "Hamlet", 55, 1, "english", 800, 2011, "novel" });
        }
    }
}
