﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FT.Lib.Data.Database.FerreTodo;

public partial class FerreTodoContext : DbContext
{
    public FerreTodoContext()
    {
    }

    public FerreTodoContext(DbContextOptions<FerreTodoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=205.209.114.122;Initial Catalog=FerreTodoElArabito;Persist Security Info=True;User ID=ElArabito;Password=?c5ta083L123$;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("ElArabito");

        modelBuilder.Entity<TipoIdentificacion>(entity =>
        {
            entity.ToTable("TipoIdentificacion", "CTG");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.ToTable("TipoUsuario", "CTG");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(25);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario", "dbo");

            entity.Property(e => e.Apellido1)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Apellido2)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Celular).HasMaxLength(15);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(60);
            entity.Property(e => e.FechaIn).HasColumnType("datetime");
            entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Identificacion)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}