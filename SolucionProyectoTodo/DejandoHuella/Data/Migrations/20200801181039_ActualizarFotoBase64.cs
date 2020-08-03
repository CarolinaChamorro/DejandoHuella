using Microsoft.EntityFrameworkCore.Migrations;

namespace DejandoHuella.Data.Migrations
{
    public partial class ActualizarFotoBase64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoBase64",
                table: "ProductoTecnologicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoBase64",
                table: "ProductoElectrodomesticos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoBase64",
                table: "ProductoTecnologicos");

            migrationBuilder.DropColumn(
                name: "FotoBase64",
                table: "ProductoElectrodomesticos");
        }
    }
}
