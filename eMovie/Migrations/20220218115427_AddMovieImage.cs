using Microsoft.EntityFrameworkCore.Migrations;

namespace eMovie.Migrations
{
    public partial class AddMovieImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_producers",
                table: "producers");

            migrationBuilder.RenameTable(
                name: "producers",
                newName: "Producers");

            migrationBuilder.AddColumn<string>(
                name: "MovieImage",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieLanguage",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "MovieImage",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieLanguage",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "producers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_producers",
                table: "producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
