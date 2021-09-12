﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBAQSEDE.Models;

namespace WEBAQSEDE.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210912182717_Anotacoes")]
    partial class Anotacoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CPF")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Entrega", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Horario_Entrega")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int?>("NomeEntregadorId")
                        .HasColumnType("int");

                    b.Property<int?>("id_pedidoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("NomeEntregadorId");

                    b.HasIndex("id_pedidoid");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Entregador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Entregadores");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Estabelecimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Estabelecimentos");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Enderecoid")
                        .HasColumnType("int");

                    b.Property<int?>("Nome_Clienteid")
                        .HasColumnType("int");

                    b.Property<int?>("Nome_Produtoid")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(35)
                        .HasColumnType("int");

                    b.Property<int?>("Valor_Produtoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Enderecoid");

                    b.HasIndex("Nome_Clienteid");

                    b.HasIndex("Nome_Produtoid");

                    b.HasIndex("Valor_Produtoid");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classificacao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<int>("Quantidade")
                        .HasMaxLength(35)
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasMaxLength(35)
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Entrega", b =>
                {
                    b.HasOne("WEBAQSEDE.Models.Dominio.Entregador", "NomeEntregador")
                        .WithMany()
                        .HasForeignKey("NomeEntregadorId");

                    b.HasOne("WEBAQSEDE.Models.Dominio.Pedido", "id_pedido")
                        .WithMany()
                        .HasForeignKey("id_pedidoid");

                    b.Navigation("id_pedido");

                    b.Navigation("NomeEntregador");
                });

            modelBuilder.Entity("WEBAQSEDE.Models.Dominio.Pedido", b =>
                {
                    b.HasOne("WEBAQSEDE.Models.Dominio.Cliente", "Endereco")
                        .WithMany()
                        .HasForeignKey("Enderecoid");

                    b.HasOne("WEBAQSEDE.Models.Dominio.Cliente", "Nome_Cliente")
                        .WithMany()
                        .HasForeignKey("Nome_Clienteid");

                    b.HasOne("WEBAQSEDE.Models.Dominio.Produto", "Nome_Produto")
                        .WithMany()
                        .HasForeignKey("Nome_Produtoid");

                    b.HasOne("WEBAQSEDE.Models.Dominio.Produto", "Valor_Produto")
                        .WithMany()
                        .HasForeignKey("Valor_Produtoid");

                    b.Navigation("Endereco");

                    b.Navigation("Nome_Cliente");

                    b.Navigation("Nome_Produto");

                    b.Navigation("Valor_Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
