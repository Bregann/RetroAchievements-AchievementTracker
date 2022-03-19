﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetroAchievementTracker.Database.Context;

#nullable disable

namespace RetroAchievementTracker.Migrations
{
    [DbContext(typeof(RetroAchievementTrackerContext))]
    partial class RetroAchievementTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.Achievements", b =>
                {
                    b.Property<string>("NameAndGameId")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumAchievedHardcore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumPossibleAchievements")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PossibleScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreAchievedHardcore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NameAndGameId");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.CompletedGames", b =>
                {
                    b.Property<string>("UsernameGameID")
                        .HasColumnType("TEXT");

                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HardcoreMode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageIcon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsernameGameID");

                    b.ToTable("CompletedGames");
                });

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.GameConsoles", b =>
                {
                    b.Property<int>("ConsoleID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConsoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ConsoleID");

                    b.ToTable("GameConsoles");
                });

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.GameCounts", b =>
                {
                    b.Property<int>("ConsoleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConsoleId");

                    b.ToTable("GameCounts");
                });

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.Games", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AchievementCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConsoleID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("GameGenre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageBoxArt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageIcon")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageIngame")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlayersCasual")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlayersHardcore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("RetroAchievementTracker.Database.Models.UserData", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedApiKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("UserData");
                });
#pragma warning restore 612, 618
        }
    }
}
