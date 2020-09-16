﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieInformation.Persistence.EF;

namespace MovieInformation.API.Migrations
{
    [DbContext(typeof(MovieInformationDbContext))]
    [Migration("20200916182808_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("MovieInformation.Domain.Cast", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("PersonId");

                    b.ToTable("Cast");
                });

            modelBuilder.Entity("MovieInformation.Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FoundedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeadquartersLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("MovieInformation.Domain.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("PersonId");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("MovieInformation.Domain.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoryLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieInformation.Domain.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("MovieInformation.Domain.Producer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("PersonId");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("MovieInformation.Domain.ProductionCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.ToTable("ProductionCompany");
                });

            modelBuilder.Entity("MovieInformation.Domain.Writer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("PersonId");

                    b.ToTable("Writer");
                });

            modelBuilder.Entity("MovieInformation.Domain.Cast", b =>
                {
                    b.HasOne("MovieInformation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", null)
                        .WithMany("Casts")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MovieInformation.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieInformation.Domain.Director", b =>
                {
                    b.HasOne("MovieInformation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", null)
                        .WithMany("Directors")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MovieInformation.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieInformation.Domain.Producer", b =>
                {
                    b.HasOne("MovieInformation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", null)
                        .WithMany("Producers")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MovieInformation.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieInformation.Domain.ProductionCompany", b =>
                {
                    b.HasOne("MovieInformation.Domain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", null)
                        .WithMany("ProductionCompanies")
                        .HasForeignKey("MovieId1");

                    b.Navigation("Company");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieInformation.Domain.Writer", b =>
                {
                    b.HasOne("MovieInformation.Domain.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieInformation.Domain.Movie", null)
                        .WithMany("Writers")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MovieInformation.Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MovieInformation.Domain.Movie", b =>
                {
                    b.Navigation("Casts");

                    b.Navigation("Directors");

                    b.Navigation("Producers");

                    b.Navigation("ProductionCompanies");

                    b.Navigation("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}