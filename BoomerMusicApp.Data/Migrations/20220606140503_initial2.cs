using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoomerMusicApp.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lenght = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Lenght", "Title" },
                values: new object[] { new Guid("83cb8a03-5fab-48a9-8dba-bb69b2909b82"), "Best Things in Life", "Dreamliners", 2.23, "Best things in life" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Lenght", "Title" },
                values: new object[] { new Guid("880f21f5-3529-45fb-bf7e-97433cd03713"), "Nase male spiwanie", "Siklawa", 3.4300000000000002, "Takiego Janicka" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumName", "Author", "Lenght", "Title" },
                values: new object[] { new Guid("8b650b0b-c0f8-4a17-a49c-3d6702633a3e"), "Lost & Found", "Jorja Smith", 4.0999999999999996, "Blue lights" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
