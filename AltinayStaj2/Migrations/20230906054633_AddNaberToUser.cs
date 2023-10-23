using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltinayStaj2.Migrations
{
    /// <inheritdoc />
    public partial class AddNaberToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Naber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naber",
                table: "Users");
        }
    }
}
