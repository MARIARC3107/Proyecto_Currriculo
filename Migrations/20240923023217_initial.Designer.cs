﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_curriculo.Context;

#nullable disable

namespace Proyecto_curriculo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240923023217_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proyecto_curriculo.Models.AProfesional", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("a_profesional")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("AProfesional");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.ATProfesionales", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("areas_profesionales")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("poblaciones_actuacion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("tareas_profesionales")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("ATProfesionales");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Competencias", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("competencia")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("condicion_contexto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("finalidad")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("objeto_conceptual")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("verbo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("id");

                    b.ToTable("Competencias");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.PActuacion", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("p_actuacion")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.HasKey("id");

                    b.ToTable("PActuacion");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Res_aprendizaje", b =>
                {
                    b.Property<string>("id_resultado")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("competencia")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("dominio_tratar")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("nivel_dominio")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("resultado_ap")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("saber_asociado")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("taxonomia")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tipo_saber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("verbo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_resultado");

                    b.ToTable("Res_aprendizaje");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Saber", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("saber")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("saber_hacer")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("saber_ser")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("id");

                    b.ToTable("Saber");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.VAgregado", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("v_agregado")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("id");

                    b.ToTable("VAgregado");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.perfil_egreso", b =>
                {
                    b.Property<string>("id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AProfesionalid")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ATProfesionalesid")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Competenciasid")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PActuacionid")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Res_aprendizajeid_resultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VAgregadoid")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("id_programa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("nmodalidad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("nombre_programa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("perfil_ocupacional")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("perfil_profesional")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.HasKey("id");

                    b.HasIndex("AProfesionalid");

                    b.HasIndex("ATProfesionalesid");

                    b.HasIndex("Competenciasid");

                    b.HasIndex("PActuacionid");

                    b.HasIndex("Res_aprendizajeid_resultado");

                    b.HasIndex("VAgregadoid");

                    b.ToTable("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.perfil_egreso", b =>
                {
                    b.HasOne("Proyecto_curriculo.Models.AProfesional", "AProfesional")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("AProfesionalid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_curriculo.Models.ATProfesionales", "ATProfesionales")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("ATProfesionalesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_curriculo.Models.Competencias", "Competencias")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("Competenciasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_curriculo.Models.PActuacion", "PActuacion")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("PActuacionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_curriculo.Models.Res_aprendizaje", "Res_aprendizaje")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("Res_aprendizajeid_resultado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_curriculo.Models.VAgregado", "VAgregado")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("VAgregadoid");

                    b.HasOne("Proyecto_curriculo.Models.Saber", "Saber")
                        .WithMany("perfil_egreso")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AProfesional");

                    b.Navigation("ATProfesionales");

                    b.Navigation("Competencias");

                    b.Navigation("PActuacion");

                    b.Navigation("Res_aprendizaje");

                    b.Navigation("Saber");

                    b.Navigation("VAgregado");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.AProfesional", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.ATProfesionales", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Competencias", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.PActuacion", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Res_aprendizaje", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.Saber", b =>
                {
                    b.Navigation("perfil_egreso");
                });

            modelBuilder.Entity("Proyecto_curriculo.Models.VAgregado", b =>
                {
                    b.Navigation("perfil_egreso");
                });
#pragma warning restore 612, 618
        }
    }
}
