using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Data.Migrations
{
    public partial class Fieldupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Original_language_id",
                table: "Film",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<short>(
                name: "Length",
                table: "Film",
                nullable: true,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Original_language_id",
                table: "Film",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Length",
                table: "Film",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);
        }
    }
}
