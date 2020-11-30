﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(CadastroDBContext))]
    [Migration("20201124181030_CriaçãoInicial")]
    partial class CriaçãoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebAPI.Models.Cadastro", b =>
                {
                    b.Property<int>("ID_funcionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Genero")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nascimento")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Salario")
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID_funcionario");

                    b.ToTable("Cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}
