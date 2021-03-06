﻿// <auto-generated />
using System;
using BOTC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BanditsOfTheCoast.Solution.Migrations
{
    [DbContext(typeof(BOTCContext))]
    partial class BOTCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("BOTC.Bandit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassId");

                    b.Property<int>("CurrentHealth");

                    b.Property<string>("Name");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Bandit");
                });

            modelBuilder.Entity("BOTC.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentHealth");

                    b.Property<int>("Dexterity");

                    b.Property<string>("Name");

                    b.Property<int>("Strength");

                    b.Property<int>("TotalHealth");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("BOTC.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BanditId");

                    b.Property<int?>("ItemId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("BanditId");

                    b.HasIndex("ItemId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("BOTC.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("BOTC.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Privileges");

                    b.Property<string>("SessionId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BOTC.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttackRange");

                    b.Property<int>("DamageDie");

                    b.Property<string>("DamageType");

                    b.Property<int>("Speed");

                    b.HasKey("Id");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("BOTC.Bandit", b =>
                {
                    b.HasOne("BOTC.Classes", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("BOTC.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BOTC.Inventory", b =>
                {
                    b.HasOne("BOTC.Bandit", "Bandit")
                        .WithMany()
                        .HasForeignKey("BanditId");

                    b.HasOne("BOTC.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
