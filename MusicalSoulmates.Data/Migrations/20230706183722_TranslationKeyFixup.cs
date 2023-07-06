using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicalSoulmates.Data.Migrations
{
    /// <inheritdoc />
    public partial class TranslationKeyFixup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseDataTranslations",
                table: "BaseDataTranslations");

            migrationBuilder.DropIndex(
                name: "IX_BaseDataTranslations_BaseDataId",
                table: "BaseDataTranslations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BaseDataTranslations");

            migrationBuilder.AlterColumn<string>(
                name: "Lang",
                table: "BaseDataTranslations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseDataTranslations",
                table: "BaseDataTranslations",
                columns: new[] { "BaseDataId", "Lang" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseDataTranslations",
                table: "BaseDataTranslations");

            migrationBuilder.AlterColumn<string>(
                name: "Lang",
                table: "BaseDataTranslations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BaseDataTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseDataTranslations",
                table: "BaseDataTranslations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BaseDataTranslations_BaseDataId",
                table: "BaseDataTranslations",
                column: "BaseDataId");
        }
    }
}
