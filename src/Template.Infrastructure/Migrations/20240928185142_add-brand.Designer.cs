﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Infrastructure.Persistence.Context;

#nullable disable

namespace Template.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240928185142_add-brand")]
    partial class addbrand
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.General.EmailConfiguration", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_alteracao");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_alteracao");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<long?>("CreationUserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_criacao");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome_exibicao");

                    b.Property<int>("EmailConfigurationType")
                        .HasColumnType("int")
                        .HasColumnName("tipo_configuracao_email");

                    b.Property<string>("EmailCopy")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("copia_email");

                    b.Property<string>("FromEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("remetente");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("senha");

                    b.Property<int>("Port")
                        .HasColumnType("int")
                        .HasColumnName("porta");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("servidor");

                    b.Property<bool>("Ssl")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ssl");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("usuario");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("configuracao_email", (string)null);
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_alteracao");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_alteracao");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<long?>("CreationUserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_criacao");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.Menu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descricao");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("icone");

                    b.Property<long?>("ParentMenuId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_menu_pai");

                    b.Property<int>("Position")
                        .HasColumnType("int")
                        .HasColumnName("posicao");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("rota");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ParentMenuId");

                    b.ToTable("menu", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Sistema",
                            Icon = "icon-sistema",
                            Position = 1,
                            Route = "/Sistema"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Usuário",
                            Icon = "icon-user",
                            ParentMenuId = 1L,
                            Position = 2,
                            Route = "/Usuario"
                        });
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_alteracao");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_alteracao");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("codigo");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<long?>("CreationUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_criacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("Language")
                        .HasColumnType("int")
                        .HasColumnName("idioma");

                    b.Property<Guid?>("LoginKey")
                        .HasColumnType("char(36)")
                        .HasColumnName("chave_login");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("senha");

                    b.Property<string>("PasswordRecoveryCode")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("codigo_recuperacao_senha");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("refresh_token");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("usuario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "001",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "christian.des.ribeiro@gmail.com",
                            Language = 0,
                            Name = "Christian Ribeiro",
                            Password = "$2a$11$252h2vGrxOa1D/ZO.SCreebeBKyQfoa8MAo4V6wx7O21U3nfxbXWO"
                        });
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.UserMenu", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_alteracao");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_alteracao");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_criacao");

                    b.Property<long?>("CreationUserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("id_usuario_criacao");

                    b.Property<bool>("Favorite")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("favorito");

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_menu");

                    b.Property<int>("Position")
                        .HasColumnType("int")
                        .HasColumnName("posicao");

                    b.Property<bool>("Visible")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("visivel");

                    b.HasKey("Id")
                        .HasName("id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("MenuId");

                    b.ToTable("menu_usuario", (string)null);
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.General.EmailConfiguration", b =>
                {
                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "ChangeUser")
                        .WithMany("ListChangeUserEmailConfiguration")
                        .HasForeignKey("ChangeUserId")
                        .HasConstraintName("fk_configuracao_email_id_usuario_alteracao");

                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "CreationUser")
                        .WithMany("ListCreationUserEmailConfiguration")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_configuracao_email_id_usuario_criacao");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.Brand", b =>
                {
                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "ChangeUser")
                        .WithMany("ListChangeUserBrand")
                        .HasForeignKey("ChangeUserId")
                        .HasConstraintName("fk_marca_id_usuario_alteracao");

                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "CreationUser")
                        .WithMany("ListCreationUserBrand")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_marca_id_usuario_criacao");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.Menu", b =>
                {
                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.Menu", "ParentMenu")
                        .WithMany("ListMenu")
                        .HasForeignKey("ParentMenuId")
                        .HasConstraintName("fk_menu_id_menu_pai");

                    b.Navigation("ParentMenu");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.User", b =>
                {
                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "ChangeUser")
                        .WithMany("ListChangeUserUser")
                        .HasForeignKey("ChangeUserId")
                        .HasConstraintName("fk_usuario_id_usuario_alteracao");

                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "CreationUser")
                        .WithMany("ListCreationUserUser")
                        .HasForeignKey("CreationUserId")
                        .HasConstraintName("fk_usuario_id_usuario_criacao");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.UserMenu", b =>
                {
                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "ChangeUser")
                        .WithMany("ListChangeUserUserMenu")
                        .HasForeignKey("ChangeUserId")
                        .HasConstraintName("fk_menu_usuario_id_usuario_alteracao");

                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.User", "CreationUser")
                        .WithMany("ListCreationUserUserMenu")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_menu_usuario_id_usuario_criacao");

                    b.HasOne("Template.Infrastructure.Persistence.Entity.Module.Registration.Menu", "Menu")
                        .WithMany("ListUserMenu")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_menu_usuario_id_menu");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.Menu", b =>
                {
                    b.Navigation("ListMenu");

                    b.Navigation("ListUserMenu");
                });

            modelBuilder.Entity("Template.Infrastructure.Persistence.Entity.Module.Registration.User", b =>
                {
                    b.Navigation("ListChangeUserBrand");

                    b.Navigation("ListChangeUserEmailConfiguration");

                    b.Navigation("ListChangeUserUser");

                    b.Navigation("ListChangeUserUserMenu");

                    b.Navigation("ListCreationUserBrand");

                    b.Navigation("ListCreationUserEmailConfiguration");

                    b.Navigation("ListCreationUserUser");

                    b.Navigation("ListCreationUserUserMenu");
                });
#pragma warning restore 612, 618
        }
    }
}
