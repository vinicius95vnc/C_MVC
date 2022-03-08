using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppMVC.Migrations
{
    public partial class Inicialcriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    CodAtv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DescAtv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vagas = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.CodAtv);
                });

            migrationBuilder.CreateTable(
                name: "AxParticipanteAtividade",
                columns: table => new
                {
                    Atividade = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AxParticipanteAtividade", x => x.Atividade);
                });

            migrationBuilder.CreateTable(
                name: "AxParticipantePacote",
                columns: table => new
                {
                    Pacote = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AxParticipantePacote", x => x.Pacote);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Preco);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    CodPar = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.CodPar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividades");

            migrationBuilder.DropTable(
                name: "AxParticipanteAtividade");

            migrationBuilder.DropTable(
                name: "AxParticipantePacote");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Participantes");
        }
    }
}
