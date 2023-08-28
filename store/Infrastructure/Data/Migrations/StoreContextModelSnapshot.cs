﻿// <auto-generated />
using System;
using Infrastructure.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameCountry")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("IdPerson")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdPersonTypeFK")
                        .HasColumnType("int");

                    b.Property<string>("NamePerson")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonTypeFK");

                    b.ToTable("person", (string)null);
                });

            modelBuilder.Entity("Core.Entities.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("personType", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("MaxStock")
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<int>("MinStock")
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("SaleValue")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ProductPerson", b =>
                {
                    b.Property<int>("IdPersonFK")
                        .HasColumnType("int");

                    b.Property<int>("IdProductFK")
                        .HasColumnType("int");

                    b.HasKey("IdPersonFK", "IdProductFK");

                    b.HasIndex("IdProductFK");

                    b.ToTable("ProductPersons");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdStateFK")
                        .HasColumnType("int");

                    b.Property<string>("NameRegion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdStateFK");

                    b.ToTable("region", (string)null);
                });

            modelBuilder.Entity("Core.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdCountryFK")
                        .HasColumnType("int");

                    b.Property<string>("NameState")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCountryFK");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Person", b =>
                {
                    b.HasOne("Core.Entities.PersonType", "PersonType")
                        .WithMany("Persons")
                        .HasForeignKey("IdPersonTypeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonType");
                });

            modelBuilder.Entity("Core.Entities.ProductPerson", b =>
                {
                    b.HasOne("Core.Entities.Person", "Person")
                        .WithMany("ProductPersons")
                        .HasForeignKey("IdPersonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Product", "Product")
                        .WithMany("ProductPersons")
                        .HasForeignKey("IdProductFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.HasOne("Core.Entities.State", "State")
                        .WithMany("Regions")
                        .HasForeignKey("IdStateFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Core.Entities.State", b =>
                {
                    b.HasOne("Core.Entities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("IdCountryFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Core.Entities.Person", b =>
                {
                    b.Navigation("ProductPersons");
                });

            modelBuilder.Entity("Core.Entities.PersonType", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Navigation("ProductPersons");
                });

            modelBuilder.Entity("Core.Entities.State", b =>
                {
                    b.Navigation("Regions");
                });
#pragma warning restore 612, 618
        }
    }
}
