using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FleetBattles.Migrations
{
    public partial class ChannelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChannelId",
                table: "Factions",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Factions_ChannelId",
                table: "Factions",
                column: "ChannelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Factions_Channels_ChannelId",
                table: "Factions",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "ChannelId",
                onDelete: ReferentialAction.SetDefault);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factions_Channels_ChannelId",
                table: "Factions");

            migrationBuilder.DropIndex(
                name: "IX_Factions_ChannelId",
                table: "Factions");

            migrationBuilder.DropColumn(
                name: "ChannelId",
                table: "Factions");
        }
    }
}
