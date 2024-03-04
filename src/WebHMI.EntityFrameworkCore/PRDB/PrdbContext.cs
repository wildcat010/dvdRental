using Abp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebHMI.Prdb;

namespace WebHMI.PRDB;

public partial class PrdbContext : AbpDbContext
{
	public PrdbContext(DbContextOptions<PrdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Spord1pc> Spord1pcs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("PRDB")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Spord1pc>(entity =>
        {
            entity.HasKey(e => new { e.Meid, e.Mecreator, e.Mesid, e.Source, e.Thickhead });

            entity.ToTable("SPORD1PC");

            entity.Property(e => e.Meid)
                .HasPrecision(10)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("1 ")
                .HasColumnName("MEID");
            entity.Property(e => e.Mecreator)
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("'' ")
                .HasColumnName("MECREATOR");
            entity.Property(e => e.Mesid)
                .HasPrecision(5)
                .HasDefaultValueSql("1 ")
                .HasColumnName("MESID");
            entity.Property(e => e.Source)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'-' ")
                .HasColumnName("SOURCE");
            entity.Property(e => e.Thickhead)
                .HasPrecision(5)
                .HasDefaultValueSql("0 ")
                .HasColumnName("THICKHEAD");
            entity.Property(e => e.Actpassno)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("ACTPASSNO");
            entity.Property(e => e.Basid)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("BASID");
            entity.Property(e => e.Calccoderm)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("CALCCODERM");
            entity.Property(e => e.Calcid)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("CALCID");
            entity.Property(e => e.Calctypemos)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("CALCTYPEMOS");
            entity.Property(e => e.Deltawidthemax)
                .HasDefaultValueSql("null \n")
                .HasColumnName("DELTAWIDTHEMAX");
            entity.Property(e => e.Deltawidthemin)
                .HasDefaultValueSql("null \n")
                .HasColumnName("DELTAWIDTHEMIN");
            entity.Property(e => e.Descalerflagrm)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("DESCALERFLAGRM");
            entity.Property(e => e.Descalerspeedrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("DESCALERSPEEDRM");
            entity.Property(e => e.Descprefillswitchrm)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("DESCPREFILLSWITCHRM");
            entity.Property(e => e.Finishdirection)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("FINISHDIRECTION");
            entity.Property(e => e.Flagcoilbox)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("FLAGCOILBOX");
            entity.Property(e => e.Furntempfromrmtarget)
                .HasDefaultValueSql("null \n")
                .HasColumnName("FURNTEMPFROMRMTARGET");
            entity.Property(e => e.Furntemppostcalc)
                .HasDefaultValueSql("null \n")
                .HasColumnName("FURNTEMPPOSTCALC");
            entity.Property(e => e.Globcorrwidth)
                .HasDefaultValueSql("null \n")
                .HasColumnName("GLOBCORRWIDTH");
            entity.Property(e => e.Handlingtyperm)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HANDLINGTYPERM");
            entity.Property(e => e.Heatcover)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HEATCOVER");
            entity.Property(e => e.Heatcover2)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HEATCOVER2");
            entity.Property(e => e.Hentrycold)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HENTRYCOLD");
            entity.Property(e => e.Hentryhotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HENTRYHOTRM");
            entity.Property(e => e.Hexitcoldrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HEXITCOLDRM");
            entity.Property(e => e.Hexithotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("HEXITHOTRM");
            entity.Property(e => e.Indexoffirstpass)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("INDEXOFFIRSTPASS");
            entity.Property(e => e.Kickbackslabflag)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("KICKBACKSLABFLAG");
            entity.Property(e => e.Length)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("LENGTH");
            entity.Property(e => e.Lentrycold)
                .HasDefaultValueSql("null \n")
                .HasColumnName("LENTRYCOLD");
            entity.Property(e => e.Lentryhotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("LENTRYHOTRM");
            entity.Property(e => e.Lexithotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("LEXITHOTRM");
            entity.Property(e => e.Lpnorm)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("LPNORM");
            entity.Property(e => e.Matstrengthcb)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MATSTRENGTHCB");
            entity.Property(e => e.Mop)
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null \n")
                .HasColumnName("MOP");
            entity.Property(e => e.Moserrorno)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MOSERRORNO");
            entity.Property(e => e.Moserrorpassno)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MOSERRORPASSNO");
            entity.Property(e => e.Moserrorprocessno)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MOSERRORPROCESSNO");
            entity.Property(e => e.Moserrorprocesstext)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MOSERRORPROCESSTEXT");
            entity.Property(e => e.Mtrpc1calcreq)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("MTRPC1CALCREQ");
            entity.Property(e => e.Offsetwidthfm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OFFSETWIDTHFM");
            entity.Property(e => e.Offsetwidthfmaps)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OFFSETWIDTHFMAPS");
            entity.Property(e => e.Offsetwidthfmintern)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OFFSETWIDTHFMINTERN");
            entity.Property(e => e.Offsetwidthfmop)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OFFSETWIDTHFMOP");
            entity.Property(e => e.Otaftdesc)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OTAFTDESC");
            entity.Property(e => e.Otbefdesc)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OTBEFDESC");
            entity.Property(e => e.Otbefshear)
                .HasDefaultValueSql("null \n")
                .HasColumnName("OTBEFSHEAR");
            entity.Property(e => e.Plannedpasssent)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PLANNEDPASSSENT");
            entity.Property(e => e.Plateproductionflag)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PLATEPRODUCTIONFLAG");
            entity.Property(e => e.Prodstepact)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPACT");
            entity.Property(e => e.Prodstepactr1)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPACTR1");
            entity.Property(e => e.Prodstepactr2)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPACTR2");
            entity.Property(e => e.Prodstepset)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPSET");
            entity.Property(e => e.Prodstepsetr1)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPSETR1");
            entity.Property(e => e.Prodstepsetr2)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PRODSTEPSETR2");
            entity.Property(e => e.Profileexcalcrelrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PROFILEEXCALCRELRM");
            entity.Property(e => e.Profileexcalcrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("PROFILEEXCALCRM");
            entity.Property(e => e.Recidrmthickness)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("RECIDRMTHICKNESS");
            entity.Property(e => e.Recidwidthoffset)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("RECIDWIDTHOFFSET");
            entity.Property(e => e.Recnodr)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("RECNODR");
            entity.Property(e => e.Refid)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("REFID");
            entity.Property(e => e.Releaseafterdeltawidth)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("RELEASEAFTERDELTAWIDTH");
            entity.Property(e => e.Rollingtime)
                .HasDefaultValueSql("null \n")
                .HasColumnName("ROLLINGTIME");
            entity.Property(e => e.Roughstripposition)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("ROUGHSTRIPPOSITION");
            entity.Property(e => e.Sbazrm)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SBAZRM");
            entity.Property(e => e.Setpointspc1calcok)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETPOINTSPC1CALCOK");
            entity.Property(e => e.Setpointspc1ok)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETPOINTSPC1OK");
            entity.Property(e => e.Setpointsprerollpc1ok)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETPOINTSPREROLLPC1OK");
            entity.Property(e => e.Setpointsrmok)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETPOINTSRMOK");
            entity.Property(e => e.Setupid)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETUPID");
            entity.Property(e => e.Setupvaliduntil)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SETUPVALIDUNTIL");
            entity.Property(e => e.Sgcenteroffseten)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGCENTEROFFSETEN");
            entity.Property(e => e.Sgcenteroffsetex)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGCENTEROFFSETEX");
            entity.Property(e => e.Sgoffsetactivepassen)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGOFFSETACTIVEPASSEN");
            entity.Property(e => e.Sgoffsetactivepassex)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGOFFSETACTIVEPASSEX");
            entity.Property(e => e.Sgoffsetfirstpassen)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGOFFSETFIRSTPASSEN");
            entity.Property(e => e.Sgoffsetinactivepassen)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGOFFSETINACTIVEPASSEN");
            entity.Property(e => e.Sgoffsetinactivepassex)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SGOFFSETINACTIVEPASSEX");
            entity.Property(e => e.Spreadfm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SPREADFM");
            entity.Property(e => e.Spreadfmnn)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SPREADFMNN");
            entity.Property(e => e.Spreadfmshort)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SPREADFMSHORT");
            entity.Property(e => e.Sptlfaultrm)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValueSql("null \n")
                .HasColumnName("SPTLFAULTRM");
            entity.Property(e => e.Startlenprimdes)
                .HasDefaultValueSql("null \n")
                .HasColumnName("STARTLENPRIMDES");
            entity.Property(e => e.Telcounter)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELCOUNTER");
            entity.Property(e => e.TeldateInd0)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELDATE_IND0");
            entity.Property(e => e.TeldateInd1)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELDATE_IND1");
            entity.Property(e => e.TeldateInd2)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELDATE_IND2");
            entity.Property(e => e.Telid)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELID");
            entity.Property(e => e.TeltimeInd0)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELTIME_IND0");
            entity.Property(e => e.TeltimeInd1)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELTIME_IND1");
            entity.Property(e => e.TeltimeInd2)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELTIME_IND2");
            entity.Property(e => e.TeltimeInd3)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TELTIME_IND3");
            entity.Property(e => e.Tentryrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TENTRYRM");
            entity.Property(e => e.Texitrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("TEXITRM");
            entity.Property(e => e.Toc)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null \n")
                .HasColumnType("DATE")
                .HasColumnName("TOC");
            entity.Property(e => e.Toextid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null \n")
                .HasColumnName("TOEXTID");
            entity.Property(e => e.Tom)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("null \n")
                .HasColumnType("DATE")
                .HasColumnName("TOM");
            entity.Property(e => e.Validsetuptime)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("VALIDSETUPTIME");
            entity.Property(e => e.Validsup)
                .HasPrecision(5)
                .HasDefaultValueSql("null \n")
                .HasColumnName("VALIDSUP");
            entity.Property(e => e.Vexitrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("VEXITRM");
            entity.Property(e => e.Waitingtimemp)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WAITINGTIMEMP");
            entity.Property(e => e.Watpressdesc)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WATPRESSDESC");
            entity.Property(e => e.Wentrycold)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WENTRYCOLD");
            entity.Property(e => e.Wentryhotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WENTRYHOTRM");
            entity.Property(e => e.Wexitcoldrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WEXITCOLDRM");
            entity.Property(e => e.Wexitcoldrmtarget)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WEXITCOLDRMTARGET");
            entity.Property(e => e.Wexithotrm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WEXITHOTRM");
            entity.Property(e => e.Wexithotrmtarget)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WEXITHOTRMTARGET");
            entity.Property(e => e.Wexitsetpcoldfm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WEXITSETPCOLDFM");
            entity.Property(e => e.Wgaugefault)
                .HasPrecision(10)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WGAUGEFAULT");
            entity.Property(e => e.Widthcofarm)
                .HasDefaultValueSql("null \n")
                .HasColumnName("WIDTHCOFARM");
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


