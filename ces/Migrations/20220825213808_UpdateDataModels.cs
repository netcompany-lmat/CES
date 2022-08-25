using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ces.Migrations
{
    public partial class UpdateDataModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "A",
                table: "Routes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "B",
                table: "Routes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Routes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CityId1",
                table: "Routes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CityId",
                table: "Routes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CityId1",
                table: "Routes",
                column: "CityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_CityId",
                table: "Routes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Cities_CityId1",
                table: "Routes",
                column: "CityId1",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_CityId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Cities_CityId1",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_CityId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_CityId1",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "A",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "B",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "Routes");
        }
    }
}
