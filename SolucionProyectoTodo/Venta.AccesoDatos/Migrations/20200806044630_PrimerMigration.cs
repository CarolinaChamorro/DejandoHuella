using Microsoft.EntityFrameworkCore.Migrations;

namespace Venta.AccesoDatos.Migrations
{
    public partial class PrimerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<string>(nullable: true),
                    CedulaIdentidad = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    DescripcionEmpresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.EmpresaId);
                });

            migrationBuilder.CreateTable(
                name: "ProductoElectrodomesticos",
                columns: table => new
                {
                    ProductoElectrodomesticoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Costo = table.Column<float>(nullable: false),
                    Medidas = table.Column<string>(nullable: true),
                    ConsumoElectrico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoElectrodomesticos", x => x.ProductoElectrodomesticoId);
                });

            migrationBuilder.CreateTable(
                name: "ProductoTecnologicos",
                columns: table => new
                {
                    ProductoTecnologicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Costo = table.Column<float>(nullable: false),
                    Medidas = table.Column<string>(nullable: true),
                    Almacenamiento = table.Column<string>(nullable: true),
                    TipoSoftware = table.Column<string>(nullable: true),
                    MemoryRam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoTecnologicos", x => x.ProductoTecnologicoId);
                });

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    BodegaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSeccion = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.BodegaId);
                    table.ForeignKey(
                        name: "FK_Bodegas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProductoElectrodomesticos",
                columns: table => new
                {
                    ClienteProductoElectrodomesticoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: false),
                    ProductoElectrodomesticoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProductoElectrodomesticos", x => x.ClienteProductoElectrodomesticoId);
                    table.ForeignKey(
                        name: "FK_ClienteProductoElectrodomesticos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                        column: x => x.ProductoElectrodomesticoId,
                        principalTable: "ProductoElectrodomesticos",
                        principalColumn: "ProductoElectrodomesticoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProductoTecnologicos",
                columns: table => new
                {
                    ClienteProductoTecnologicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: false),
                    ProductoTecnologicoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProductoTecnologicos", x => x.ClienteProductoTecnologicoId);
                    table.ForeignKey(
                        name: "FK_ClienteProductoTecnologicos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                        column: x => x.ProductoTecnologicoId,
                        principalTable: "ProductoTecnologicos",
                        principalColumn: "ProductoTecnologicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodegaProductoElectrodomesticos",
                columns: table => new
                {
                    BodegaProductoElectrodomesticoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodegaId = table.Column<int>(nullable: false),
                    ProductoElectrodomesticoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodegaProductoElectrodomesticos", x => x.BodegaProductoElectrodomesticoId);
                    table.ForeignKey(
                        name: "FK_BodegaProductoElectrodomesticos_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodegaProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                        column: x => x.ProductoElectrodomesticoId,
                        principalTable: "ProductoElectrodomesticos",
                        principalColumn: "ProductoElectrodomesticoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodegaProductoTecnologicos",
                columns: table => new
                {
                    BodegaProductoTecnologicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodegaId = table.Column<int>(nullable: false),
                    ProductoTecnologicoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodegaProductoTecnologicos", x => x.BodegaProductoTecnologicoId);
                    table.ForeignKey(
                        name: "FK_BodegaProductoTecnologicos_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BodegaProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                        column: x => x.ProductoTecnologicoId,
                        principalTable: "ProductoTecnologicos",
                        principalColumn: "ProductoTecnologicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodegaProductoElectrodomesticos_BodegaId",
                table: "BodegaProductoElectrodomesticos",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_BodegaProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaProductoElectrodomesticos",
                column: "ProductoElectrodomesticoId");

            migrationBuilder.CreateIndex(
                name: "IX_BodegaProductoTecnologicos_BodegaId",
                table: "BodegaProductoTecnologicos",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_BodegaProductoTecnologicos_ProductoTecnologicoId",
                table: "BodegaProductoTecnologicos",
                column: "ProductoTecnologicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_EmpresaId",
                table: "Bodegas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProductoElectrodomesticos_ClienteId",
                table: "ClienteProductoElectrodomesticos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteProductoElectrodomesticos",
                column: "ProductoElectrodomesticoId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProductoTecnologicos_ClienteId",
                table: "ClienteProductoTecnologicos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProductoTecnologicos_ProductoTecnologicoId",
                table: "ClienteProductoTecnologicos",
                column: "ProductoTecnologicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodegaProductoElectrodomesticos");

            migrationBuilder.DropTable(
                name: "BodegaProductoTecnologicos");

            migrationBuilder.DropTable(
                name: "ClienteProductoElectrodomesticos");

            migrationBuilder.DropTable(
                name: "ClienteProductoTecnologicos");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "ProductoElectrodomesticos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ProductoTecnologicos");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
