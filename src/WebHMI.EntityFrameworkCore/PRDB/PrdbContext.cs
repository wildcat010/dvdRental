using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebHMI.PRDB;

public partial class PrdbContext : AbpDbContext
{
    public PrdbContext(DbContextOptions<PrdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Stddirdccoiler> Stddirdccoilers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("PRDB")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Stddirdccoiler>(entity =>
        {
            entity.HasKey(e => new { e.Planno, e.Activeflag });

            entity.ToTable("STDDIRDCCOILER");

            entity.Property(e => e.Planno)
                .HasPrecision(10)
                .HasDefaultValueSql("0 ")
                .HasColumnName("PLANNO");
            entity.Property(e => e.Activeflag)
                .HasPrecision(10)
                .HasDefaultValueSql("0 ")
                .HasColumnName("ACTIVEFLAG");
            entity.Property(e => e.Description)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("null\n")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Description2)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasDefaultValueSql("null ")
                .HasColumnName("DESCRIPTION2");
            entity.Property(e => e.Manint)
                .HasPrecision(5)
                .HasDefaultValueSql("null\n")
                .HasColumnName("MANINT");
            entity.Property(e => e.Mop)
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null\n")
                .HasColumnName("MOP");
            entity.Property(e => e.Toc)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null\n")
                .HasColumnType("DATE")
                .HasColumnName("TOC");
            entity.Property(e => e.Tom)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null\n")
                .HasColumnType("DATE")
                .HasColumnName("TOM");
        });
        modelBuilder.HasSequence("BASID")
            .IncrementsBy(10)
            .IsCyclic();
        modelBuilder.HasSequence("CSCALIBRATIONCONFIGID");
        modelBuilder.HasSequence("CSMAINTENANCEVALVESTESTID");
        modelBuilder.HasSequence("MEID").IsCyclic();
        modelBuilder.HasSequence("RECID");
        modelBuilder.HasSequence("VPRUNIT").IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}


