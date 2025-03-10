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

    public virtual DbSet<Cliente> Clientes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC071BA3ADA2");

            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
