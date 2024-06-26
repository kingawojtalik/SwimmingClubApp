﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwimmingClubApp.Data;

#nullable disable

namespace SwimmingClubApp.Migrations
{
    [DbContext(typeof(SwimmingClubAppContext))]
    [Migration("20240528111129_SwimmingClubApp")]
    partial class SwimmingClubApp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SwimmingClubApp.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompetitionId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompetitionId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultId"));

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("Medal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Place")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("Stroke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SwimmerId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("ResultId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("SwimmerId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Swimmer", b =>
                {
                    b.Property<int>("SwimmerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SwimmerId"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SwimmingGroupId")
                        .HasColumnType("int");

                    b.HasKey("SwimmerId");

                    b.HasIndex("SwimmingGroupId");

                    b.ToTable("Swimmers");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.SwimmingGroup", b =>
                {
                    b.Property<int>("SwimmingGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SwimmingGroupId"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SwimmingGroupId");

                    b.ToTable("SwimmingGroups");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingId"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SwimmingGroupId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("TrainingTime")
                        .HasColumnType("time");

                    b.HasKey("TrainingId");

                    b.HasIndex("SwimmingGroupId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Result", b =>
                {
                    b.HasOne("SwimmingClubApp.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingClubApp.Models.Swimmer", "Swimmer")
                        .WithMany()
                        .HasForeignKey("SwimmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("Swimmer");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Swimmer", b =>
                {
                    b.HasOne("SwimmingClubApp.Models.SwimmingGroup", "SwimmingGroup")
                        .WithMany()
                        .HasForeignKey("SwimmingGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SwimmingGroup");
                });

            modelBuilder.Entity("SwimmingClubApp.Models.Training", b =>
                {
                    b.HasOne("SwimmingClubApp.Models.SwimmingGroup", "SwimmingGroup")
                        .WithMany()
                        .HasForeignKey("SwimmingGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SwimmingGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
