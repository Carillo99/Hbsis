using IncomeTax.Domain.Entities;
using IncomeTax.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IncomeTax.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxpayer>()
            .HasOne(p => p.TaxpayerIR)
            .WithOne(i => i.Taxpayer)
            .HasForeignKey<TaxpayerIR>(b => b.TaxpayerId);

            modelBuilder.Entity<Taxpayer>()
            .HasOne(p => p.MinimumWage)
            .WithOne(i => i.Taxpayer)
            .HasForeignKey<MinimumWage>(b => b.TaxpayerId);

            modelBuilder.ApplyConfiguration(new MinimumWageMap());
            modelBuilder.ApplyConfiguration(new TaxpayerMap());
            modelBuilder.ApplyConfiguration(new TaxpayerIRMap());

            #region Confugura��es
            modelBuilder.Entity<Taxpayer>().ToTable("Taxpayer");
            modelBuilder.Entity<TaxpayerIR>().ToTable("TaxpayerIR");
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #region BdSet
        public DbSet<Taxpayer> Taxpayer { get; set; }
        public DbSet<TaxpayerIR> TaxpayerIR { get; set; }
        #endregion
        
    }
}

