using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltinayStaj2.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberPlateToSaveData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumberPlate",
                table: "SaveDatas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberPlate",
                table: "SaveDatas");
        }
    }
}
