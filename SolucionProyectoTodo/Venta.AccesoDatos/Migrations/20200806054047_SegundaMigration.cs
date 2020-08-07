using Microsoft.EntityFrameworkCore.Migrations;

namespace Venta.AccesoDatos.Migrations
{
    public partial class SegundaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProductoElectrodomesticos_Bodegas_BodegaId",
                table: "BodegaProductoElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaProductoElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProductoTecnologicos_Bodegas_BodegaId",
                table: "BodegaProductoTecnologicos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                table: "BodegaProductoTecnologicos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteProductoElectrodomesticos_Clientes_ClienteId",
                table: "ClienteProductoElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteProductoElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteProductoTecnologicos_Clientes_ClienteId",
                table: "ClienteProductoTecnologicos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                table: "ClienteProductoTecnologicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoTecnologicos",
                table: "ProductoTecnologicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoElectrodomesticos",
                table: "ProductoElectrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteProductoTecnologicos",
                table: "ClienteProductoTecnologicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteProductoElectrodomesticos",
                table: "ClienteProductoElectrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegaProductoTecnologicos",
                table: "BodegaProductoTecnologicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegaProductoElectrodomesticos",
                table: "BodegaProductoElectrodomesticos");

            migrationBuilder.RenameTable(
                name: "ProductoTecnologicos",
                newName: "AparatosTecnologicos");

            migrationBuilder.RenameTable(
                name: "ProductoElectrodomesticos",
                newName: "Electrodomesticos");

            migrationBuilder.RenameTable(
                name: "ClienteProductoTecnologicos",
                newName: "ClienteConAparatoTecnologico");

            migrationBuilder.RenameTable(
                name: "ClienteProductoElectrodomesticos",
                newName: "ClienteConElectrodomesticos");

            migrationBuilder.RenameTable(
                name: "BodegaProductoTecnologicos",
                newName: "BodegaDeTecnologia");

            migrationBuilder.RenameTable(
                name: "BodegaProductoElectrodomesticos",
                newName: "BodegaDeElectrodomesticos");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteProductoTecnologicos_ProductoTecnologicoId",
                table: "ClienteConAparatoTecnologico",
                newName: "IX_ClienteConAparatoTecnologico_ProductoTecnologicoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteProductoTecnologicos_ClienteId",
                table: "ClienteConAparatoTecnologico",
                newName: "IX_ClienteConAparatoTecnologico_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteConElectrodomesticos",
                newName: "IX_ClienteConElectrodomesticos_ProductoElectrodomesticoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteProductoElectrodomesticos_ClienteId",
                table: "ClienteConElectrodomesticos",
                newName: "IX_ClienteConElectrodomesticos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProductoTecnologicos_ProductoTecnologicoId",
                table: "BodegaDeTecnologia",
                newName: "IX_BodegaDeTecnologia_ProductoTecnologicoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProductoTecnologicos_BodegaId",
                table: "BodegaDeTecnologia",
                newName: "IX_BodegaDeTecnologia_BodegaId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaDeElectrodomesticos",
                newName: "IX_BodegaDeElectrodomesticos_ProductoElectrodomesticoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaProductoElectrodomesticos_BodegaId",
                table: "BodegaDeElectrodomesticos",
                newName: "IX_BodegaDeElectrodomesticos_BodegaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AparatosTecnologicos",
                table: "AparatosTecnologicos",
                column: "ProductoTecnologicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Electrodomesticos",
                table: "Electrodomesticos",
                column: "ProductoElectrodomesticoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteConAparatoTecnologico",
                table: "ClienteConAparatoTecnologico",
                column: "ClienteProductoTecnologicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteConElectrodomesticos",
                table: "ClienteConElectrodomesticos",
                column: "ClienteProductoElectrodomesticoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegaDeTecnologia",
                table: "BodegaDeTecnologia",
                column: "BodegaProductoTecnologicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegaDeElectrodomesticos",
                table: "BodegaDeElectrodomesticos",
                column: "BodegaProductoElectrodomesticoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaDeElectrodomesticos_Bodegas_BodegaId",
                table: "BodegaDeElectrodomesticos",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "BodegaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaDeElectrodomesticos_Electrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaDeElectrodomesticos",
                column: "ProductoElectrodomesticoId",
                principalTable: "Electrodomesticos",
                principalColumn: "ProductoElectrodomesticoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaDeTecnologia_Bodegas_BodegaId",
                table: "BodegaDeTecnologia",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "BodegaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaDeTecnologia_AparatosTecnologicos_ProductoTecnologicoId",
                table: "BodegaDeTecnologia",
                column: "ProductoTecnologicoId",
                principalTable: "AparatosTecnologicos",
                principalColumn: "ProductoTecnologicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteConAparatoTecnologico_Clientes_ClienteId",
                table: "ClienteConAparatoTecnologico",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteConAparatoTecnologico_AparatosTecnologicos_ProductoTecnologicoId",
                table: "ClienteConAparatoTecnologico",
                column: "ProductoTecnologicoId",
                principalTable: "AparatosTecnologicos",
                principalColumn: "ProductoTecnologicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteConElectrodomesticos_Clientes_ClienteId",
                table: "ClienteConElectrodomesticos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteConElectrodomesticos_Electrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteConElectrodomesticos",
                column: "ProductoElectrodomesticoId",
                principalTable: "Electrodomesticos",
                principalColumn: "ProductoElectrodomesticoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodegaDeElectrodomesticos_Bodegas_BodegaId",
                table: "BodegaDeElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaDeElectrodomesticos_Electrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaDeElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaDeTecnologia_Bodegas_BodegaId",
                table: "BodegaDeTecnologia");

            migrationBuilder.DropForeignKey(
                name: "FK_BodegaDeTecnologia_AparatosTecnologicos_ProductoTecnologicoId",
                table: "BodegaDeTecnologia");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteConAparatoTecnologico_Clientes_ClienteId",
                table: "ClienteConAparatoTecnologico");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteConAparatoTecnologico_AparatosTecnologicos_ProductoTecnologicoId",
                table: "ClienteConAparatoTecnologico");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteConElectrodomesticos_Clientes_ClienteId",
                table: "ClienteConElectrodomesticos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClienteConElectrodomesticos_Electrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteConElectrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Electrodomesticos",
                table: "Electrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteConElectrodomesticos",
                table: "ClienteConElectrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteConAparatoTecnologico",
                table: "ClienteConAparatoTecnologico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegaDeTecnologia",
                table: "BodegaDeTecnologia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodegaDeElectrodomesticos",
                table: "BodegaDeElectrodomesticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AparatosTecnologicos",
                table: "AparatosTecnologicos");

            migrationBuilder.RenameTable(
                name: "Electrodomesticos",
                newName: "ProductoElectrodomesticos");

            migrationBuilder.RenameTable(
                name: "ClienteConElectrodomesticos",
                newName: "ClienteProductoElectrodomesticos");

            migrationBuilder.RenameTable(
                name: "ClienteConAparatoTecnologico",
                newName: "ClienteProductoTecnologicos");

            migrationBuilder.RenameTable(
                name: "BodegaDeTecnologia",
                newName: "BodegaProductoTecnologicos");

            migrationBuilder.RenameTable(
                name: "BodegaDeElectrodomesticos",
                newName: "BodegaProductoElectrodomesticos");

            migrationBuilder.RenameTable(
                name: "AparatosTecnologicos",
                newName: "ProductoTecnologicos");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteConElectrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteProductoElectrodomesticos",
                newName: "IX_ClienteProductoElectrodomesticos_ProductoElectrodomesticoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteConElectrodomesticos_ClienteId",
                table: "ClienteProductoElectrodomesticos",
                newName: "IX_ClienteProductoElectrodomesticos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteConAparatoTecnologico_ProductoTecnologicoId",
                table: "ClienteProductoTecnologicos",
                newName: "IX_ClienteProductoTecnologicos_ProductoTecnologicoId");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteConAparatoTecnologico_ClienteId",
                table: "ClienteProductoTecnologicos",
                newName: "IX_ClienteProductoTecnologicos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaDeTecnologia_ProductoTecnologicoId",
                table: "BodegaProductoTecnologicos",
                newName: "IX_BodegaProductoTecnologicos_ProductoTecnologicoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaDeTecnologia_BodegaId",
                table: "BodegaProductoTecnologicos",
                newName: "IX_BodegaProductoTecnologicos_BodegaId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaDeElectrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaProductoElectrodomesticos",
                newName: "IX_BodegaProductoElectrodomesticos_ProductoElectrodomesticoId");

            migrationBuilder.RenameIndex(
                name: "IX_BodegaDeElectrodomesticos_BodegaId",
                table: "BodegaProductoElectrodomesticos",
                newName: "IX_BodegaProductoElectrodomesticos_BodegaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoElectrodomesticos",
                table: "ProductoElectrodomesticos",
                column: "ProductoElectrodomesticoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteProductoElectrodomesticos",
                table: "ClienteProductoElectrodomesticos",
                column: "ClienteProductoElectrodomesticoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteProductoTecnologicos",
                table: "ClienteProductoTecnologicos",
                column: "ClienteProductoTecnologicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegaProductoTecnologicos",
                table: "BodegaProductoTecnologicos",
                column: "BodegaProductoTecnologicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodegaProductoElectrodomesticos",
                table: "BodegaProductoElectrodomesticos",
                column: "BodegaProductoElectrodomesticoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoTecnologicos",
                table: "ProductoTecnologicos",
                column: "ProductoTecnologicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProductoElectrodomesticos_Bodegas_BodegaId",
                table: "BodegaProductoElectrodomesticos",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "BodegaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "BodegaProductoElectrodomesticos",
                column: "ProductoElectrodomesticoId",
                principalTable: "ProductoElectrodomesticos",
                principalColumn: "ProductoElectrodomesticoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProductoTecnologicos_Bodegas_BodegaId",
                table: "BodegaProductoTecnologicos",
                column: "BodegaId",
                principalTable: "Bodegas",
                principalColumn: "BodegaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodegaProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                table: "BodegaProductoTecnologicos",
                column: "ProductoTecnologicoId",
                principalTable: "ProductoTecnologicos",
                principalColumn: "ProductoTecnologicoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteProductoElectrodomesticos_Clientes_ClienteId",
                table: "ClienteProductoElectrodomesticos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteProductoElectrodomesticos_ProductoElectrodomesticos_ProductoElectrodomesticoId",
                table: "ClienteProductoElectrodomesticos",
                column: "ProductoElectrodomesticoId",
                principalTable: "ProductoElectrodomesticos",
                principalColumn: "ProductoElectrodomesticoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteProductoTecnologicos_Clientes_ClienteId",
                table: "ClienteProductoTecnologicos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteProductoTecnologicos_ProductoTecnologicos_ProductoTecnologicoId",
                table: "ClienteProductoTecnologicos",
                column: "ProductoTecnologicoId",
                principalTable: "ProductoTecnologicos",
                principalColumn: "ProductoTecnologicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
