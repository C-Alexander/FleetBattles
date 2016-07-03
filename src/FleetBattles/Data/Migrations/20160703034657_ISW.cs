using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FleetBattles.Data.Migrations
{
    public partial class ISW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adjective = table.Column<string>(nullable: true),
                    AvatarURL = table.Column<string>(nullable: true),
                    IconURL = table.Column<string>(nullable: true),
                    LogoURL = table.Column<string>(nullable: true),
                    LongName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faction", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "FactionId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FactionId",
                table: "AspNetUsers",
                column: "FactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FactionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FactionId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Faction");
        }
    }
}
