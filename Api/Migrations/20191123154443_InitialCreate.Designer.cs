﻿// <auto-generated />
using System;
using Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(SIUGlobalContext))]
    [Migration("20191123154443_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Exercicio", b =>
                {
                    b.Property<int>("IDExercicio")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chave");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("IDTipo");

                    b.Property<int>("Status");

                    b.HasKey("IDExercicio");

                    b.HasIndex("IDTipo");

                    b.ToTable("Exercicio");
                });

            modelBuilder.Entity("Domain.Entities.Ficha", b =>
                {
                    b.Property<int>("IDFicha")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataFinalizacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("DiaSeq");

                    b.Property<int>("Status");

                    b.HasKey("IDFicha");

                    b.ToTable("Ficha");
                });

            modelBuilder.Entity("Domain.Entities.FichaExercicio", b =>
                {
                    b.Property<int>("IDFichaExercicio")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Carga");

                    b.Property<int?>("IDExercicio");

                    b.Property<int?>("IDFicha");

                    b.Property<string>("Repeticao");

                    b.Property<int?>("Serie");

                    b.HasKey("IDFichaExercicio");

                    b.HasIndex("IDExercicio");

                    b.HasIndex("IDFicha");

                    b.ToTable("FichaExercicio");
                });

            modelBuilder.Entity("Domain.Entities.FilaFicha", b =>
                {
                    b.Property<int>("IDFilaFicha")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Executado");

                    b.Property<int?>("IDFicha");

                    b.HasKey("IDFilaFicha");

                    b.HasIndex("IDFicha");

                    b.ToTable("FilaFicha");
                });

            modelBuilder.Entity("Domain.Entities.Tipo", b =>
                {
                    b.Property<int>("IDTipo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Status");

                    b.HasKey("IDTipo");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("Domain.Entities.Exercicio", b =>
                {
                    b.HasOne("Domain.Entities.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("IDTipo")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Domain.Entities.FichaExercicio", b =>
                {
                    b.HasOne("Domain.Entities.Exercicio", "Exercicio")
                        .WithMany()
                        .HasForeignKey("IDExercicio");

                    b.HasOne("Domain.Entities.Ficha", "Ficha")
                        .WithMany()
                        .HasForeignKey("IDFicha");
                });

            modelBuilder.Entity("Domain.Entities.FilaFicha", b =>
                {
                    b.HasOne("Domain.Entities.Ficha", "Ficha")
                        .WithMany()
                        .HasForeignKey("IDFicha");
                });
#pragma warning restore 612, 618
        }
    }
}
