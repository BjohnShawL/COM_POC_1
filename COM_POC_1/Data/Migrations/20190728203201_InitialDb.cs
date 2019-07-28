using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COM_POC_1.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rifts",
                columns: table => new
                {
                    RiftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Mystery = table.Column<string>(nullable: true),
                    CurrentlyActive = table.Column<bool>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rifts", x => x.RiftId);
                    table.ForeignKey(
                        name: "FK_Rifts_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    RiftId = table.Column<int>(nullable: true),
                    CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeId);
                    table.ForeignKey(
                        name: "FK_Themes_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attentions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marked = table.Column<bool>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attentions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attentions_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marked = table.Column<bool>(nullable: false),
                    ThemeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildUps_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cracks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marked = table.Column<bool>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cracks_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marked = table.Column<bool>(nullable: false),
                    ThemeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fades_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerTags",
                columns: table => new
                {
                    PowerTagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsDynamite = table.Column<bool>(nullable: false),
                    ThemeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerTags", x => x.PowerTagId);
                    table.ForeignKey(
                        name: "FK_PowerTags_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "ThemeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attentions_ThemeId",
                table: "Attentions",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildUps_ThemeId",
                table: "BuildUps",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlayerId",
                table: "Characters",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cracks_ThemeId",
                table: "Cracks",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fades_ThemeId",
                table: "Fades",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerTags_ThemeId",
                table: "PowerTags",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rifts_CharacterId",
                table: "Rifts",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_CharacterId",
                table: "Themes",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attentions");

            migrationBuilder.DropTable(
                name: "BuildUps");

            migrationBuilder.DropTable(
                name: "Cracks");

            migrationBuilder.DropTable(
                name: "Fades");

            migrationBuilder.DropTable(
                name: "PowerTags");

            migrationBuilder.DropTable(
                name: "Rifts");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
