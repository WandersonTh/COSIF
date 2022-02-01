using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COSIF.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movimento_Manual",
                columns: table => new
                {
                    NUM_LANCAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DAT_MES = table.Column<int>(type: "int", nullable: false),
                    DAT_ANO = table.Column<int>(type: "int", nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_COSIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DES_DESCRICAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DAT_MOVIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAL_VALOR = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimento_Manual", x => x.NUM_LANCAMENTO);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    COD_PRODUTO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DES_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STA_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.COD_PRODUTO);
                });

            migrationBuilder.CreateTable(
                name: "Produto_Cosif",
                columns: table => new
                {
                    COD_COSIF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    COD_PRODUTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD_CLASSIFICACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STA_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto_Cosif", x => x.COD_COSIF);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimento_Manual");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Produto_Cosif");
        }
    }
}
