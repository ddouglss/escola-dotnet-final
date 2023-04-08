using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace escoladotnet_.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    descicao = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    prefil = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    requisitos = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    conteudo = table.Column<string>(type: "text", nullable: false),
                    recursos = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ch = table.Column<int>(type: "int", nullable: false),
                    prazo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
