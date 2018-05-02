using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
