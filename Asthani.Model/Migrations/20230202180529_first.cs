using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asthani.Model.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableHolderInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VarChar50 = table.Column<string>(name: "VarChar(50)", type: "nvarchar(max)", nullable: true),
                    NumberOfFamilyMembers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableHolderInfo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableHolderInfo");
        }
    }
}
