using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestorPacientes.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DeletePhotoFromPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
