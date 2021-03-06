﻿// <auto-generated />
using EFCore_12_IntroModels.Many_to_many;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore_12_IntroModels.Migrations.Thing
{
    [DbContext(typeof(ThingContext))]
    [Migration("20191220183836_ManyToMany_relationsip_was_added")]
    partial class ManyToMany_relationsip_was_added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore_12_IntroModels.Many_to_many.Models.Element", b =>
                {
                    b.Property<int>("SerialNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mass")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SerialNum");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("EFCore_12_IntroModels.Many_to_many.Models.Substance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Substances");
                });

            modelBuilder.Entity("EFCore_12_IntroModels.Many_to_many.Models.SubstanceElement", b =>
                {
                    b.Property<int>("SubstanceId")
                        .HasColumnType("int");

                    b.Property<int>("ElementSerialNum")
                        .HasColumnType("int");

                    b.HasKey("SubstanceId", "ElementSerialNum");

                    b.HasIndex("ElementSerialNum");

                    b.ToTable("SubstanceElement");
                });

            modelBuilder.Entity("EFCore_12_IntroModels.Many_to_many.Models.SubstanceElement", b =>
                {
                    b.HasOne("EFCore_12_IntroModels.Many_to_many.Models.Element", "Element")
                        .WithMany("SubstanceElements")
                        .HasForeignKey("ElementSerialNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore_12_IntroModels.Many_to_many.Models.Substance", "Substance")
                        .WithMany("SubstanceElements")
                        .HasForeignKey("SubstanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
