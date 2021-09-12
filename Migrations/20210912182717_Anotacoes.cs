using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBAQSEDE.Migrations
{
    public partial class Anotacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Classificacao = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Quantidade = table.Column<int>(type: "int", maxLength: 35, nullable: false),
                    Valor = table.Column<float>(type: "real", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Clienteid = table.Column<int>(type: "int", nullable: true),
                    Enderecoid = table.Column<int>(type: "int", nullable: true),
                    Nome_Produtoid = table.Column<int>(type: "int", nullable: true),
                    Valor_Produtoid = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cliente_Enderecoid",
                        column: x => x.Enderecoid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cliente_Nome_Clienteid",
                        column: x => x.Nome_Clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Produtos_Nome_Produtoid",
                        column: x => x.Nome_Produtoid,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Produtos_Valor_Produtoid",
                        column: x => x.Valor_Produtoid,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_pedidoid = table.Column<int>(type: "int", nullable: true),
                    NomeEntregadorId = table.Column<int>(type: "int", nullable: true),
                    Horario_Entrega = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Entregas_Entregadores_NomeEntregadorId",
                        column: x => x.NomeEntregadorId,
                        principalTable: "Entregadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entregas_Pedidos_id_pedidoid",
                        column: x => x.id_pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_id_pedidoid",
                table: "Entregas",
                column: "id_pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Entregas_NomeEntregadorId",
                table: "Entregas",
                column: "NomeEntregadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Enderecoid",
                table: "Pedidos",
                column: "Enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Nome_Clienteid",
                table: "Pedidos",
                column: "Nome_Clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Nome_Produtoid",
                table: "Pedidos",
                column: "Nome_Produtoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Valor_Produtoid",
                table: "Pedidos",
                column: "Valor_Produtoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entregas");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
