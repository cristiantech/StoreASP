using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Backend.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "roles",
                newName: "Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Name",
                table: "roles",
                newName: "IX_roles_Nombre");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "roles",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Nombre",
                table: "roles",
                newName: "IX_roles_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}