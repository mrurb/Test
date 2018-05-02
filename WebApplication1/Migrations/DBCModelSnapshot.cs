﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication1.data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DBC))]
    partial class DBCModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("WebApplication1.Models.mainm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("User1id");

                    b.Property<int?>("User2id");

                    b.HasKey("Id");

                    b.HasIndex("User1id");

                    b.HasIndex("User2id");

                    b.ToTable("mainm");
                });

            modelBuilder.Entity("WebApplication1.Models.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("username");

                    b.HasKey("id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("WebApplication1.Models.Userlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("mainmId");

                    b.Property<int?>("userid");

                    b.HasKey("Id");

                    b.HasIndex("mainmId");

                    b.HasIndex("userid");

                    b.ToTable("Userlist");
                });

            modelBuilder.Entity("WebApplication1.Models.mainm", b =>
                {
                    b.HasOne("WebApplication1.Models.user", "User1")
                        .WithMany()
                        .HasForeignKey("User1id");

                    b.HasOne("WebApplication1.Models.user", "User2")
                        .WithMany()
                        .HasForeignKey("User2id");
                });

            modelBuilder.Entity("WebApplication1.Models.Userlist", b =>
                {
                    b.HasOne("WebApplication1.Models.mainm", "mainm")
                        .WithMany("Userlist")
                        .HasForeignKey("mainmId");

                    b.HasOne("WebApplication1.Models.user", "user")
                        .WithMany()
                        .HasForeignKey("userid");
                });
#pragma warning restore 612, 618
        }
    }
}
