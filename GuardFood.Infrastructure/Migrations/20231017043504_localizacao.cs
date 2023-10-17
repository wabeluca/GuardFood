using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuardFood.Infrastructure.Migrations
{
    public partial class localizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Localizacao",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Localizacao",
                table: "Pedidos");
        }
    }
}
