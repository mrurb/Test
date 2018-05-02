using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mainmId = table.Column<int>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mainm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User1id = table.Column<int>(nullable: true),
                    User2id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mainm_user_User1id",
                        column: x => x.User1id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mainm_user_User2id",
                        column: x => x.User2id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mainm_User1id",
                table: "mainm",
                column: "User1id");

            migrationBuilder.CreateIndex(
                name: "IX_mainm_User2id",
                table: "mainm",
                column: "User2id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mainm_user_User1id",
                table: "mainm");

            migrationBuilder.DropForeignKey(
                name: "FK_mainm_user_User2id",
                table: "mainm");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "mainm");
        }
    }
}
