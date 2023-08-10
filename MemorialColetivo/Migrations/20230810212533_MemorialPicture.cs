using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorialColetivo.Migrations
{
    /// <inheritdoc />
    public partial class MemorialPicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemorialPictureURL",
                table: "Memorial",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemorialPictureURL",
                table: "Memorial");
        }
    }
}
