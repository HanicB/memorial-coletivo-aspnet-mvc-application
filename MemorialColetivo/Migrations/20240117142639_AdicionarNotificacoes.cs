using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemorialColetivo.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarNotificacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notificacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemorialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificacao_Memorial_MemorialId",
                        column: x => x.MemorialId,
                        principalTable: "Memorial",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notificacao_MemorialId",
                table: "Notificacao",
                column: "MemorialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notificacao");
        }
    }
}
