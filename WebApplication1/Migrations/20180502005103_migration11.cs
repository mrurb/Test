using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userlist_mainm_mainmId",
                table: "userlist");

            migrationBuilder.DropForeignKey(
                name: "FK_userlist_user_userid",
                table: "userlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userlist",
                table: "userlist");

            migrationBuilder.RenameTable(
                name: "userlist",
                newName: "Userlist");

            migrationBuilder.RenameIndex(
                name: "IX_userlist_userid",
                table: "Userlist",
                newName: "IX_Userlist_userid");

            migrationBuilder.RenameIndex(
                name: "IX_userlist_mainmId",
                table: "Userlist",
                newName: "IX_Userlist_mainmId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Userlist",
                table: "Userlist",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Userlist_mainm_mainmId",
                table: "Userlist",
                column: "mainmId",
                principalTable: "mainm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Userlist_user_userid",
                table: "Userlist",
                column: "userid",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Userlist_mainm_mainmId",
                table: "Userlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Userlist_user_userid",
                table: "Userlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Userlist",
                table: "Userlist");

            migrationBuilder.RenameTable(
                name: "Userlist",
                newName: "userlist");

            migrationBuilder.RenameIndex(
                name: "IX_Userlist_userid",
                table: "userlist",
                newName: "IX_userlist_userid");

            migrationBuilder.RenameIndex(
                name: "IX_Userlist_mainmId",
                table: "userlist",
                newName: "IX_userlist_mainmId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userlist",
                table: "userlist",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userlist_mainm_mainmId",
                table: "userlist",
                column: "mainmId",
                principalTable: "mainm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userlist_user_userid",
                table: "userlist",
                column: "userid",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
