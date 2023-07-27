using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicalSoulmates.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLanauges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRTL = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
