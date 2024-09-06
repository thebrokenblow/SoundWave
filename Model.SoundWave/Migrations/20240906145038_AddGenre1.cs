using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.SoundWave.Migrations
{
    /// <inheritdoc />
    public partial class AddGenre1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrlPreviewImg",
                table: "Albums",
                newName: "UrlPreview");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrlPreview",
                table: "Albums",
                newName: "UrlPreviewImg");
        }
    }
}
