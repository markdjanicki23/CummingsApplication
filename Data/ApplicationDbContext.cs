using System;
using System.Collections.Generic;
using System.Text;
using CummingsApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CummingsApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<BailBondInfo> BailBondInfos { get; set; }

            public DbSet<ProvidingAgency> ProvidingAgencies { get; set; }
            
            public DbSet<Jail> Jails { get; set; }

            public DbSet<BondTransfer> BondTransfers { get; set; }

            public DbSet<RequestingAgency> RequestingAgencies { get; set; }

            public DbSet<Defendant> Defendants { get; set; }
        
            public DbSet<Indemnitor> Indemnitors { get; set; }

            public DbSet<AdditionalInfo> AdditionalInfos { get; set; }
    }   
}
