using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicalSoulmates.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseData_BaseData_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BaseData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BaseDataTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseDataId = table.Column<int>(type: "int", nullable: false),
                    Lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseDataTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseDataTranslations_BaseData_BaseDataId",
                        column: x => x.BaseDataId,
                        principalTable: "BaseData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseData_ParentId",
                table: "BaseData",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseDataTranslations_BaseDataId",
                table: "BaseDataTranslations",
                column: "BaseDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseDataTranslations");

            migrationBuilder.DropTable(
                name: "BaseData");
        }
    }
}
