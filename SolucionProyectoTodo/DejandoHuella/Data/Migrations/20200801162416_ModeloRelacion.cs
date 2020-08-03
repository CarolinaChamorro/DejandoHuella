using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DejandoHuella.Data.Migrations
{
    public partial class ModeloRelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<string>(nullable: true),
                    CedulaIdentidad = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    DescripcionEmpresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bodegas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductoElectrodomesticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Costo = table.Column<float>(nullable: false),
                    Medidas = table.Column<string>(nullable: true),
                    ConsumoElectrico = table.Column<string>(nullable: true),
                    IdBodega = table.Column<int>(nullable: true),
                    BodegaId = table.Column<int>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoElectrodomesticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoElectrodomesticos_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductoTecnologicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Costo = table.Column<float>(nullable: false),
                    Medidas = table.Column<string>(nullable: true),
                    Almacenamiento = table.Column<string>(nullable: true),
                    TipoSoftware = table.Column<string>(nullable: true),
                    MemoryRam = table.Column<float>(nullable: false),
                    IdBodega = table.Column<int>(nullable: true),
                    BodegaId = table.Column<int>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoTecnologicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoTecnologicos_Bodegas_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProductoElectrodomesticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    IdProductoElectrodomestico = table.Column<int>(nullable: true),
                    ProductoElectrodomesticoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProductoElectrodomesticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteProductoElectrodomesticos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                        column: x => x.ProductoElectrodomesticoId,
                        principalTable: "ProductoElectrodomesticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProductoTecnologicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: true),
                    IdProductoTecnologico = table.Column<int>(nullable: true),
                    ProductoTecnologicoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProductoTecnologicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteProductoTecnologicos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                        column: x => x.ProductoTecnologicoId,
                        principalTable: "ProductoTecnologicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductoElectrodomesticos_BodegaId",
                table: "ProductoElectrodomesticos",
                column: "BodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoTecnologicos_BodegaId",
                table: "ProductoTecnologicos",
                column: "BodegaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteProductoElectrodomesticos");

            migrationBuilder.DropTable(
                name: "ClienteProductoTecnologicos");

            migrationBuilder.DropTable(
                name: "ProductoElectrodomesticos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ProductoTecnologicos");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
