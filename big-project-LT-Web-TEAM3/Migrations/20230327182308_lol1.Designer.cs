﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using big_project_LT_Web_TEAM3.Models;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230327182308_lol1")]
    partial class lol1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Classify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classify");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassifysId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhiterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClassifysId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.SendDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentOwer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SendedDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("SendDocument");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChucVuGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Document", b =>
                {
                    b.HasOne("big_project_LT_Web_TEAM3.Models.Classify", "Classifys")
                        .WithMany("Tags")
                        .HasForeignKey("ClassifysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classifys");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.SendDocument", b =>
                {
                    b.HasOne("big_project_LT_Web_TEAM3.Models.Document", "Document")
                        .WithMany("SendDocuments")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Classify", b =>
                {
                    b.Navigation("Tags");
                });

            modelBuilder.Entity("big_project_LT_Web_TEAM3.Models.Document", b =>
                {
                    b.Navigation("SendDocuments");
                });
#pragma warning restore 612, 618
        }
    }
}
