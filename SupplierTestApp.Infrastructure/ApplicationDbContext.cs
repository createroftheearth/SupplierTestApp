using Microsoft.EntityFrameworkCore;
using SupplierTestApp.Application.Common.Interfaces;
using SupplierTestApp.Domain.Entities;

namespace SupplierTestApp.Infrastructure
{
    public class ApplicationDbContext :DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierRate> SupplierRate { get; set; }

    }
}
