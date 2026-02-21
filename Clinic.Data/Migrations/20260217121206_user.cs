using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_queues_ClientId",
                table: "queues",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_queues_DoctorId",
                table: "queues",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_queues_clients_ClientId",
                table: "queues",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_queues_doctors_DoctorId",
                table: "queues",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_queues_clients_ClientId",
                table: "queues");

            migrationBuilder.DropForeignKey(
                name: "FK_queues_doctors_DoctorId",
                table: "queues");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropIndex(
                name: "IX_queues_ClientId",
                table: "queues");

            migrationBuilder.DropIndex(
                name: "IX_queues_DoctorId",
                table: "queues");
        }
    }
}
