using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mainm_userlist_Userlistid",
                table: "mainm");

            migrationBuilder.DropForeignKey(
                name: "FK_user_userlist_userlistid",
                table: "user");

            migrationBuilder.DropTable(
                name: "userlist");

            migrationBuilder.DropIndex(
                name: "IX_mainm_Userlistid",
                table: "mainm");

            migrationBuilder.DropColumn(
                name: "Userlistid",
                table: "mainm");

            migrationBuilder.RenameColumn(
                name: "userlistid",
                table: "user",
                newName: "mainmId");

            migrationBuilder.RenameIndex(
                name: "IX_user_userlistid",
                table: "user",
                newName: "IX_user_mainmId");

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
                name: "FK_user_mainm_mainmId",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "mainmId",
                table: "user",
                newName: "userlistid");

            migrationBuilder.RenameIndex(
                name: "IX_user_mainmId",
                table: "user",
                newName: "IX_user_userlistid");

            migrationBuilder.AddColumn<int>(
                name: "Userlistid",
                table: "mainm",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userlist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlist", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mainm_Userlistid",
                table: "mainm",
                column: "Userlistid");

            migrationBuilder.AddForeignKey(
                name: "FK_mainm_userlist_Userlistid",
                table: "mainm",
                column: "Userlistid",
                principalTable: "userlist",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_user_userlist_userlistid",
                table: "user",
                column: "userlistid",
                principalTable: "userlist",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
