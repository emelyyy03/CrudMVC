using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD.AppMVCDataFirst.Models;

public partial class CatalogosDbdataFirstContext : DbContext
{
    public CatalogosDbdataFirstContext()
    {
    }

    public CatalogosDbdataFirstContext(DbContextOptions<CatalogosDbdataFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<MetodosDePago> MetodosDePagos { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TiposDeDocumento> TiposDeDocumentos { get; set; }

    public virtual DbSet<UnidadesDeMedidum> UnidadesDeMedida { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-5PGNA2S\\SQLEXPRESS;Initial Catalog=CatalogosDBDataFirst;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC073B4108E5");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC071BA3ADA2");

            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departam__3214EC078FB749E0");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empleado__3214EC07FD001A8A");

            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Puesto).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Equipos__3214EC07EC2763D4");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estados__3214EC07880334BA");

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<MetodosDePago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MetodosD__3214EC07DE46C2BA");

            entity.ToTable("MetodosDePago");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monedas__3214EC070F0968B2");

            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Simbolo).HasMaxLength(10);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC0707352C26");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC074D057C08");

            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proyecto__3214EC071E8FB8B8");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC078C380DFC");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TiposDeDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TiposDeD__3214EC07DD609905");

            entity.ToTable("TiposDeDocumento");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<UnidadesDeMedidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Unidades__3214EC07B6E7F3A8");

            entity.Property(e => e.Abreviatura).HasMaxLength(10);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
