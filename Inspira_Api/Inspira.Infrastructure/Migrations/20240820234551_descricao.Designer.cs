﻿// <auto-generated />
using System;
using Inspira.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Inspira.Infrastructure.Migrations
{
    [DbContext(typeof(InspiraDbContext))]
    [Migration("20240820234551_descricao")]
    partial class descricao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ArtistTrack", b =>
                {
                    b.Property<Guid>("ArtistsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TracksId")
                        .HasColumnType("uuid");

                    b.HasKey("ArtistsId", "TracksId");

                    b.HasIndex("TracksId");

                    b.ToTable("ArtistTrack");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uuid");

                    b.Property<string>("CoverUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<Guid>("TrackDestId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TrackSourceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TrackDestId");

                    b.HasIndex("TrackSourceId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Track", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Inspira_Music.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Inspira_Music.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArtistTrack", b =>
                {
                    b.HasOne("Inspira.Domain.Entities.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inspira.Domain.Entities.Track", null)
                        .WithMany()
                        .HasForeignKey("TracksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Album", b =>
                {
                    b.HasOne("Inspira.Domain.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Post", b =>
                {
                    b.HasOne("Inspira.Domain.Entities.Track", "TrackDest")
                        .WithMany()
                        .HasForeignKey("TrackDestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inspira.Domain.Entities.Track", "TrackSource")
                        .WithMany("Posts")
                        .HasForeignKey("TrackSourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inspira_Music.Domain.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrackDest");

                    b.Navigation("TrackSource");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Track", b =>
                {
                    b.HasOne("Inspira.Domain.Entities.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Inspira_Music.Domain.Entities.Comment", b =>
                {
                    b.HasOne("Inspira.Domain.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inspira_Music.Domain.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Inspira.Domain.Entities.Track", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Inspira_Music.Domain.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
