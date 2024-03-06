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

    public virtual DbSet<VMatStructEntry> VMatStructEntries { get; set; }

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

        modelBuilder.Entity<VMatStructEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MAT_STRUCT_ENTRY");

            entity.Property(e => e.Enlobasid)
                .HasPrecision(5)
                .HasColumnName("ENLOBASID");
            entity.Property(e => e.Enlocreator)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENLOCREATOR");
            entity.Property(e => e.Enloextid)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENLOEXTID");
            entity.Property(e => e.Enlomeid)
                .HasPrecision(10)
                .HasColumnName("ENLOMEID");
            entity.Property(e => e.Enlomesid)
                .HasPrecision(5)
                .HasColumnName("ENLOMESID");
            entity.Property(e => e.Enlometype)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENLOMETYPE");
            entity.Property(e => e.Enlostatus)
                .HasPrecision(5)
                .HasColumnName("ENLOSTATUS");
            entity.Property(e => e.Enorbasid)
                .HasPrecision(5)
                .HasColumnName("ENORBASID");
            entity.Property(e => e.Enorcreator)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENORCREATOR");
            entity.Property(e => e.Enorextid)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENOREXTID");
            entity.Property(e => e.Enormeid)
                .HasPrecision(10)
                .HasColumnName("ENORMEID");
            entity.Property(e => e.Enormesid)
                .HasPrecision(5)
                .HasColumnName("ENORMESID");
            entity.Property(e => e.Enormetype)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENORMETYPE");
            entity.Property(e => e.Enorstatus)
                .HasPrecision(5)
                .HasColumnName("ENORSTATUS");
            entity.Property(e => e.Enphbasid)
                .HasPrecision(5)
                .HasColumnName("ENPHBASID");
            entity.Property(e => e.Enphcreator)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENPHCREATOR");
            entity.Property(e => e.Enphextid)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ENPHEXTID");
            entity.Property(e => e.Enphmeid)
                .HasPrecision(10)
                .HasColumnName("ENPHMEID");
            entity.Property(e => e.Enphmesid)
                .HasPrecision(5)
                .HasColumnName("ENPHMESID");
            entity.Property(e => e.Enphmetype)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ENPHMETYPE");
            entity.Property(e => e.Enphstatus)
                .HasPrecision(5)
                .HasColumnName("ENPHSTATUS");
            entity.Property(e => e.Lastupdate)
                .HasColumnType("DATE")
                .HasColumnName("LASTUPDATE");
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


