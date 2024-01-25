using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authentication.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "90d3a314-8d90-4811-a438-bb91cd787924", "2", "Candidat", "CANDIDAT" },
                    { "aca04416-49c3-4d9f-bd8b-54d61f7379e1", "3", "Entreprise", "ENTREPRISE" },
                    { "e5cd33b7-a3b1-41ea-be15-0e5fed7e77ba", "1", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90d3a314-8d90-4811-a438-bb91cd787924");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca04416-49c3-4d9f-bd8b-54d61f7379e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5cd33b7-a3b1-41ea-be15-0e5fed7e77ba");
        }
    }
}
