using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication7.Data.Migrations
{
    public partial class InitialDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            return;
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Film_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Release_year = table.Column<string>(nullable: true),
                    Language_id = table.Column<byte>(nullable: false),
                    Original_language_id = table.Column<byte>(nullable: false),
                    Rental_duration = table.Column<byte>(nullable: false),
                    Rental_rate = table.Column<decimal>(nullable: false),
                    Length = table.Column<short>(nullable: false),
                    Replacement_cost = table.Column<decimal>(nullable: false),
                    Rating = table.Column<string>(nullable: true),
                    Special_features = table.Column<string>(nullable: true),
                    Last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Film_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            return;

            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
