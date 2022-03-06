using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class UpdateCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowsBilling",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AllowsShipping",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumericIsoCode",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ThreeLetterIsoCode",
                table: "Countries",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TwoLetterIsoCode",
                table: "Countries",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowsBilling",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "AllowsShipping",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "NumericIsoCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ThreeLetterIsoCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "TwoLetterIsoCode",
                table: "Countries");
        }
    }
}
