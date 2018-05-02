using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_mainm_mainmId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_mainmId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "mainmId",
                table: "user");

            migrationBuilder.CreateTable(
                name: "userlist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mainmId = table.Column<int>(nullable: true),
                    userid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userlist_mainm_mainmId",
                        column: x => x.mainmId,
                        principalTable: "mainm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_userlist_user_userid",
                        column: x => x.userid,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userlist_mainmId",
                table: "userlist",
                column: "mainmId");

            migrationBuilder.CreateIndex(
                name: "IX_userlist_userid",
                table: "userlist",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userlist");

            migrationBuilder.AddColumn<int>(
                name: "mainmId",
                table: "user",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_mainmId",
                table: "user",
                column: "mainmId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_mainm_mainmId",
                table: "user",
                column: "mainmId",
                principalTable: "mainm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
