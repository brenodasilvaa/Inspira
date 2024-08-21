using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inspira.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class descricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Posts",
                type: "character varying(5000)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Posts");
        }
    }
}
