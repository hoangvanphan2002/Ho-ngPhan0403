﻿// <auto-generated />
using HoangVanPhan0403.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HoangVanPhan0403.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240616162114_Create_table_Disigner")]
    partial class Create_table_Disigner
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("HoangVanPhan0403.Models.SinhVien", b =>
                {
                    b.Property<string>("SinhVienId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.HasKey("SinhVienId");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
