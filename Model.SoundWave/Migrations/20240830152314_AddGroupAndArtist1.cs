using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.SoundWave.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupAndArtist1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Groups_GroupId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_GroupId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Albums");

            migrationBuilder.RenameColumn(
                name: "UrlPrevieImg",
                table: "Albums",
                newName: "UrlPreviewImg");

            migrationBuilder.CreateTable(
                name: "AlbumGroup",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "int", nullable: false),
                    GroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGroup", x => new { x.AlbumsId, x.GroupsId });
                    table.ForeignKey(
                        name: "FK_AlbumGroup_Albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumGroup_Groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGroup_GroupsId",
                table: "AlbumGroup",
                column: "GroupsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumGroup");

            migrationBuilder.RenameColumn(
                name: "UrlPreviewImg",
                table: "Albums",
                newName: "UrlPrevieImg");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GroupId",
                table: "Albums",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Groups_GroupId",
                table: "Albums",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
