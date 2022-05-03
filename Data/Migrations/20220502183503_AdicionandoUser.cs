using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppMVC.Data.Migrations
{
    public partial class AdicionandoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Participantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Participantes");
        }
    }
}
