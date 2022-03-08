﻿// <auto-generated />
using System;
using AppMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppMVC.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppMVC.Models.Atividades", b =>
                {
                    b.Property<string>("CodAtv")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CodAtv");

                    b.Property<string>("DescAtv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescAtv");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Preco");

                    b.Property<int>("Vagas")
                        .HasColumnType("int")
                        .HasColumnName("Vagas");

                    b.HasKey("CodAtv");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("AppMVC.Models.AxParticipanteAtividade", b =>
                {
                    b.Property<string>("Atividade")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Atividade");

                    b.HasKey("Atividade");

                    b.ToTable("AxParticipanteAtividade");
                });

            modelBuilder.Entity("AppMVC.Models.AxParticipantePacote", b =>
                {
                    b.Property<string>("Pacote")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Pacote");

                    b.HasKey("Pacote");

                    b.ToTable("AxParticipantePacote");
                });

            modelBuilder.Entity("AppMVC.Models.Pacotes", b =>
                {
                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Preco");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.HasKey("Preco");

                    b.ToTable("Pacotes");
                });

            modelBuilder.Entity("AppMVC.Models.Participantes", b =>
                {
                    b.Property<string>("CodPar")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("CodPar");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Telefone");

                    b.HasKey("CodPar");

                    b.ToTable("Participantes");
                });
#pragma warning restore 612, 618
        }
    }
}