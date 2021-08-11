using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareERP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoteID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoteID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Substancia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laboratorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoGgrem = table.Column<long>(type: "bigint", nullable: false),
                    Registro = table.Column<long>(type: "bigint", nullable: false),
                    Ean1 = table.Column<long>(type: "bigint", nullable: false),
                    Ean2 = table.Column<long>(type: "bigint", nullable: false),
                    Ean3 = table.Column<long>(type: "bigint", nullable: false),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apresentacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClasseTerapeutica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegimePreco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PfSemImpostos = table.Column<double>(type: "float", nullable: false),
                    Pf0 = table.Column<double>(type: "float", nullable: false),
                    Pf12 = table.Column<double>(type: "float", nullable: false),
                    Pf17 = table.Column<double>(type: "float", nullable: false),
                    Pf17Alc = table.Column<double>(type: "float", nullable: false),
                    Pf175 = table.Column<double>(type: "float", nullable: false),
                    Pf175Alc = table.Column<double>(type: "float", nullable: false),
                    Pf18 = table.Column<double>(type: "float", nullable: false),
                    Pf18Alc = table.Column<double>(type: "float", nullable: false),
                    Pf20 = table.Column<double>(type: "float", nullable: false),
                    Pmc0 = table.Column<double>(type: "float", nullable: false),
                    Pmc12 = table.Column<double>(type: "float", nullable: false),
                    Pmc17 = table.Column<double>(type: "float", nullable: false),
                    Pmc17Alc = table.Column<double>(type: "float", nullable: false),
                    Pmc175 = table.Column<double>(type: "float", nullable: false),
                    Pmc175Alc = table.Column<double>(type: "float", nullable: false),
                    Pmc18 = table.Column<double>(type: "float", nullable: false),
                    Pmc18Alc = table.Column<double>(type: "float", nullable: false),
                    Pmc20 = table.Column<double>(type: "float", nullable: false),
                    RestricaoHospitalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confaz87 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icms0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnaliseRecursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListaConcessaoCreditoTributario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comercializacao2020 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Medicines_Storages_StorageID",
                        column: x => x.StorageID,
                        principalTable: "Storages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_StorageID",
                table: "Medicines",
                column: "StorageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Storages");
        }
    }
}
