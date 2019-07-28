using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COM_POC_1.Migrations
{
    public partial class Db_V_0_B_0_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "McId",
                table: "Characters",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mcs",
                columns: table => new
                {
                    McId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mcs", x => x.McId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modifier = table.Column<int>(nullable: false),
                    PosNeg = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "GameNotes",
                columns: table => new
                {
                    GameNotesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    McId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameNotes", x => x.GameNotesId);
                    table.ForeignKey(
                        name: "FK_GameNotes_Mcs_McId",
                        column: x => x.McId,
                        principalTable: "Mcs",
                        principalColumn: "McId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    McId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Mcs_McId",
                        column: x => x.McId,
                        principalTable: "Mcs",
                        principalColumn: "McId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoryTags",
                columns: table => new
                {
                    StoryTagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Modifier = table.Column<int>(nullable: false),
                    PosNeg = table.Column<bool>(nullable: false),
                    scope = table.Column<int>(nullable: false),
                    McId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryTags", x => x.StoryTagId);
                    table.ForeignKey(
                        name: "FK_StoryTags_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_GameId",
                table: "Players",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_McId",
                table: "Characters",
                column: "McId");

            migrationBuilder.CreateIndex(
                name: "IX_GameNotes_McId",
                table: "GameNotes",
                column: "McId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_McId",
                table: "Games",
                column: "McId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_GameId",
                table: "StoryTags",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Mcs_McId",
                table: "Characters",
                column: "McId",
                principalTable: "Mcs",
                principalColumn: "McId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Games_GameId",
                table: "Players",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Mcs_McId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Games_GameId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "GameNotes");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "StoryTags");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Mcs");

            migrationBuilder.DropIndex(
                name: "IX_Players_GameId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Characters_McId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "McId",
                table: "Characters");
        }
    }
}
