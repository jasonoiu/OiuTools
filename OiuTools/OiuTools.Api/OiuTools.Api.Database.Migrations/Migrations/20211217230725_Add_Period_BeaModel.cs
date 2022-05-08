using Microsoft.EntityFrameworkCore.Migrations;

namespace OiuTools.Api.Database.Migrations.Migrations
{
    public partial class Add_Period_BeaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "BeautyModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "BeautyModel");
        }
    }
}
