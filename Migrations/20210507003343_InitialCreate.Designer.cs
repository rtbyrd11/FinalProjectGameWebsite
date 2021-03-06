// <auto-generated />
using FinalProjectGameWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProjectGameWebsite.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210507003343_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("FinalProjectGameWebsite.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WeaponOfChoice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CharacterId");

                    b.HasIndex("GameId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("FinalProjectGameWebsite.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("FinalProjectGameWebsite.Models.Character", b =>
                {
                    b.HasOne("FinalProjectGameWebsite.Models.Game", "Game")
                        .WithMany("Characters")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("FinalProjectGameWebsite.Models.Game", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
