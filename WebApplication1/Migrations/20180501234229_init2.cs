using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mainm_user_user1id",
                table: "mainm");

            migrationBuilder.DropForeignKey(
                name: "FK_mainm_user_user2id",
                table: "mainm");

            migrationBuilder.RenameColumn(
                name: "user2id",
                table: "mainm",
                newName: "User2id");

            migrationBuilder.RenameColumn(
                name: "user1id",
                table: "mainm",
                newName: "User1id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "mainm",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_mainm_user2id",
                table: "mainm",
                newName: "IX_mainm_User2id");

            migrationBuilder.RenameIndex(
                name: "IX_mainm_user1id",
                table: "mainm",
                newName: "IX_mainm_User1id");

            migrationBuilder.AddColumn<int>(
                name: "mainmId",
                table: "user",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_mainmId",
                table: "user",
                column: "mainmId");

            migrationBuilder.AddForeignKey(
                name: "FK_mainm_user_User1id",
                table: "mainm",
                column: "User1id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_mainm_user_User2id",
                table: "mainm",
                column: "User2id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.DropForeignKey(
                name: "FK_user_mainm_mainmId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_mainmId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "mainmId",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "User2id",
                table: "mainm",
                newName: "user2id");

            migrationBuilder.RenameColumn(
                name: "User1id",
                table: "mainm",
                newName: "user1id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "mainm",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_mainm_User2id",
                table: "mainm",
                newName: "IX_mainm_user2id");

            migrationBuilder.RenameIndex(
                name: "IX_mainm_User1id",
                table: "mainm",
                newName: "IX_mainm_user1id");

            migrationBuilder.AddForeignKey(
                name: "FK_mainm_user_user1id",
                table: "mainm",
                column: "user1id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_mainm_user_user2id",
                table: "mainm",
                column: "user2id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
