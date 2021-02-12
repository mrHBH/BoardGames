﻿// <auto-generated />
using System;
using BoardGames.HostServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BoardGames.Migrations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BoardGames.HostServices.DbChatMessage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ChatId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EditedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("boolean");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ChatId", "CreatedAt");

                    b.HasIndex("ChatId", "Id", "CreatedAt");

                    b.HasIndex("UserId", "ChatId", "CreatedAt");

                    b.HasIndex("UserId", "CreatedAt", "ChatId");

                    b.HasIndex("UserId", "ChatId", "Id", "CreatedAt");

                    b.HasIndex("UserId", "Id", "CreatedAt", "ChatId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("BoardGames.HostServices.DbGame", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EndedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EngineId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Intro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastMoveAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("MaxScore")
                        .HasColumnType("bigint");

                    b.Property<int?>("RoundCount")
                        .HasColumnType("integer");

                    b.Property<int>("RoundIndex")
                        .HasColumnType("integer");

                    b.Property<int>("Stage")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StateJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StateMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Stage", "IsPublic", "CreatedAt");

                    b.HasIndex("UserId", "CreatedAt", "Stage");

                    b.HasIndex("UserId", "Stage", "CreatedAt");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("BoardGames.HostServices.DbGamePlayer", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("DbGameId")
                        .HasColumnType("text");

                    b.Property<string>("EngineId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<long>("Score")
                        .HasColumnType("bigint");

                    b.HasKey("GameId", "UserId");

                    b.HasIndex("DbGameId");

                    b.HasIndex("EngineId", "Score");

                    b.ToTable("GamePlayers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FriendlyName")
                        .HasColumnType("text");

                    b.Property<string>("Xml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Authentication.DbSessionInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AuthenticatedIdentity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSignOutForced")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastSeenAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("OptionsJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt", "IsSignOutForced");

                    b.HasIndex("IPAddress", "IsSignOutForced");

                    b.HasIndex("LastSeenAt", "IsSignOutForced");

                    b.HasIndex("UserId", "IsSignOutForced");

                    b.ToTable("_Sessions");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Authentication.DbUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimsJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Authentication.DbUserIdentity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<long?>("DbUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DbUserId");

                    b.HasIndex("Id");

                    b.ToTable("UserIdentities");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Operations.DbOperation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AgentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CommandJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CommitTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ItemsJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CommitTime" }, "IX_CommitTime");

                    b.HasIndex(new[] { "StartTime" }, "IX_StartTime");

                    b.ToTable("_Operations");
                });

            modelBuilder.Entity("BoardGames.HostServices.DbGamePlayer", b =>
                {
                    b.HasOne("BoardGames.HostServices.DbGame", null)
                        .WithMany("Players")
                        .HasForeignKey("DbGameId");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Authentication.DbUserIdentity", b =>
                {
                    b.HasOne("Stl.Fusion.EntityFramework.Authentication.DbUser", null)
                        .WithMany("Identities")
                        .HasForeignKey("DbUserId");
                });

            modelBuilder.Entity("BoardGames.HostServices.DbGame", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Stl.Fusion.EntityFramework.Authentication.DbUser", b =>
                {
                    b.Navigation("Identities");
                });
#pragma warning restore 612, 618
        }
    }
}
