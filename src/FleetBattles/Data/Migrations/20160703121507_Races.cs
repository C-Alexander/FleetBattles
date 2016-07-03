using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FleetBattles.Data.Migrations
{
    public partial class Races : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AvatarURL",
                table: "Faction");

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adjective = table.Column<string>(maxLength: 15, nullable: false),
                    AvatarURL = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "DefaultRaceId",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "AspNetUsers",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Faction",
                maxLength: 15,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "LongName",
                table: "Faction",
                maxLength: 35,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "LogoURL",
                table: "Faction",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "IconURL",
                table: "Faction",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Adjective",
                table: "Faction",
                maxLength: 15,
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Faction_DefaultRaceId",
                table: "Faction",
                column: "DefaultRaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faction_Race_DefaultRaceId",
                table: "Faction",
                column: "DefaultRaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Faction_Race_DefaultRaceId",
                table: "Faction");

            migrationBuilder.DropIndex(
                name: "IX_Faction_DefaultRaceId",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "DefaultRaceId",
                table: "Faction");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.AddColumn<string>(
                name: "AvatarURL",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortName",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LongName",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogoURL",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IconURL",
                table: "Faction",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adjective",
                table: "Faction",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Faction_FactionId",
                table: "AspNetUsers",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
