﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QuizGame.Server.Models;

#nullable disable

namespace QuizGame.Server.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    [Migration("20240822134846_UsersUpdate")]
    partial class UsersUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("QuizGame.Server.Models.OperatingSystems", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("a_answer")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("b_answer")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("c_answer")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("correct_answer")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("d_answer")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasColumnType("char(100)");

                    b.Property<string>("questions")
                        .IsRequired()
                        .HasColumnType("char(250)");

                    b.HasKey("id");

                    b.ToTable("OperatingSystems");
                });

            modelBuilder.Entity("QuizGame.Server.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("char(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("char(50)");

                    b.Property<string>("password")
                        .HasColumnType("char(50)");

                    b.Property<int?>("quiz_time")
                        .HasColumnType("integer");

                    b.Property<int?>("score")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
