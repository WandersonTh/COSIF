﻿// <auto-generated />
using System;
using COSIF.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COSIF.Api.Migrations
{
    [DbContext(typeof(CosifContext))]
    [Migration("20220201001038_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("COSIF.Api.Models.Movimento_Manual", b =>
                {
                    b.Property<int>("NUM_LANCAMENTO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("COD_COSIF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_USUARIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DAT_ANO")
                        .HasColumnType("int");

                    b.Property<int>("DAT_MES")
                        .HasColumnType("int");

                    b.Property<DateTime>("DAT_MOVIMENTO")
                        .HasColumnType("datetime2");

                    b.Property<string>("DES_DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("VAL_VALOR")
                        .HasColumnType("float");

                    b.HasKey("NUM_LANCAMENTO");

                    b.ToTable("Movimento_Manual");
                });

            modelBuilder.Entity("COSIF.Api.Models.Produto", b =>
                {
                    b.Property<string>("COD_PRODUTO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DES_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STA_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_PRODUTO");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("COSIF.Api.Models.Produto_Cosif", b =>
                {
                    b.Property<string>("COD_COSIF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("COD_CLASSIFICACAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COD_PRODUTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STA_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_COSIF");

                    b.ToTable("Produto_Cosif");
                });
#pragma warning restore 612, 618
        }
    }
}