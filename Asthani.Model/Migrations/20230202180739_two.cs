using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asthani.Model.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VarChar(50)",
                table: "TableHolderInfo",
                newName: "TableHolderName");

            migrationBuilder.AlterColumn<string>(
                name: "TableHolderName",
                table: "TableHolderInfo",
                type: "VarChar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TableHolderName",
                table: "TableHolderInfo",
                newName: "VarChar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "VarChar(50)",
                table: "TableHolderInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VarChar(50)",
                oldNullable: true);
        }
    }
}
