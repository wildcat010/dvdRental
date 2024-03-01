using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace WebHMI.EntityFrameworkCore.PRDB
{
    public partial class PrdbContext : AbpDbContext
    {
        public PrdbContext(DbContextOptions<PrdbContext> options)
            : base(options)
        {
        }
        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

