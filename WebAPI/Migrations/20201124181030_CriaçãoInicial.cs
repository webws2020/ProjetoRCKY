using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class CriaçãoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    ID_funcionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nascimento = table.Column<string>(type: "varchar(10)", nullable: true),
                    Salario = table.Column<string>(type: "varchar(20)", nullable: true),
                    Genero = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.ID_funcionario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");
        }
    }
}
