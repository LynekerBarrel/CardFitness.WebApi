using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ficha",
                columns: table => new
                {
                    IDFicha = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataFinalizacao = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DiaSeq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficha", x => x.IDFicha);
                });

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    IDTipo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.IDTipo);
                });

            migrationBuilder.CreateTable(
                name: "FilaFicha",
                columns: table => new
                {
                    IDFilaFicha = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDFicha = table.Column<int>(nullable: true),
                    Executado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilaFicha", x => x.IDFilaFicha);
                    table.ForeignKey(
                        name: "FK_FilaFicha_Ficha_IDFicha",
                        column: x => x.IDFicha,
                        principalTable: "Ficha",
                        principalColumn: "IDFicha",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercicio",
                columns: table => new
                {
                    IDExercicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDTipo = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    Chave = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicio", x => x.IDExercicio);
                    table.ForeignKey(
                        name: "FK_Exercicio_Tipo_IDTipo",
                        column: x => x.IDTipo,
                        principalTable: "Tipo",
                        principalColumn: "IDTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FichaExercicio",
                columns: table => new
                {
                    IDFichaExercicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDFicha = table.Column<int>(nullable: true),
                    IDExercicio = table.Column<int>(nullable: true),
                    Repeticao = table.Column<string>(nullable: true),
                    Serie = table.Column<int>(nullable: true),
                    Carga = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaExercicio", x => x.IDFichaExercicio);
                    table.ForeignKey(
                        name: "FK_FichaExercicio_Exercicio_IDExercicio",
                        column: x => x.IDExercicio,
                        principalTable: "Exercicio",
                        principalColumn: "IDExercicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichaExercicio_Ficha_IDFicha",
                        column: x => x.IDFicha,
                        principalTable: "Ficha",
                        principalColumn: "IDFicha",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercicio_IDTipo",
                table: "Exercicio",
                column: "IDTipo");

            migrationBuilder.CreateIndex(
                name: "IX_FichaExercicio_IDExercicio",
                table: "FichaExercicio",
                column: "IDExercicio");

            migrationBuilder.CreateIndex(
                name: "IX_FichaExercicio_IDFicha",
                table: "FichaExercicio",
                column: "IDFicha");

            migrationBuilder.CreateIndex(
                name: "IX_FilaFicha_IDFicha",
                table: "FilaFicha",
                column: "IDFicha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichaExercicio");

            migrationBuilder.DropTable(
                name: "FilaFicha");

            migrationBuilder.DropTable(
                name: "Exercicio");

            migrationBuilder.DropTable(
                name: "Ficha");

            migrationBuilder.DropTable(
                name: "Tipo");
        }
    }
}
