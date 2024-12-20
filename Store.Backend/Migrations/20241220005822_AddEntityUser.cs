using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_roles_IdCountryId",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "roles",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Nombre",
                table: "roles",
                newName: "IX_roles_Name");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_roles_RolId",
                        column: x => x.RolId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RolId",
                table: "Users",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_roles_IdCountryId",
                table: "Countries",
                column: "IdCountryId",
                principalTable: "roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_roles_IdCountryId",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "roles",
                newName: "Nombre");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Name",
                table: "roles",
                newName: "IX_roles_Nombre");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_roles_IdCountryId",
                table: "Countries",
                column: "IdCountryId",
                principalTable: "roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
