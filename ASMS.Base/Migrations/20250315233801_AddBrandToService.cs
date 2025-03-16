using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASMS.Base.Migrations
{
    /// <inheritdoc />
    public partial class AddBrandToService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "Services",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "Services");
        }
    }
}
