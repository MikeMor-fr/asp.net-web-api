using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SelfieAWookies.Core.Selfies.Domain;
using SelfieAWookies.Core.Selfies.Infrastructure.Data.TypeConfigurations;
using SelfiesAWookies.Core.Framework;

namespace SelfieAWookies.Core.Selfies.Infrastructure.Data
{
    public class SelfiesContext : DbContext, IUnitOfWork
    {
        public SelfiesContext([NotNull] DbContextOptions options) : base(options) { }

        public SelfiesContext() : base() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }
        
        public DbSet<Selfie> Selfies { get; set; }
        public DbSet<Wookie> Wookies { get; set; }
    }
}