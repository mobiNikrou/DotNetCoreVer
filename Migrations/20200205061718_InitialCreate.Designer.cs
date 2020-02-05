﻿// <auto-generated />
using DotNetCoreVer1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreVer1.Migrations
{
    [DbContext(typeof(TestResultContext))]
    [Migration("20200205061718_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("DotNetCoreVer1.Models.TestingResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TestCheck1")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestCheck2")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestCheck3")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestingResult");
                });
#pragma warning restore 612, 618
        }
    }
}