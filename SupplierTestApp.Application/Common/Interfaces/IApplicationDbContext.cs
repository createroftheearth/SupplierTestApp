using Microsoft.EntityFrameworkCore;
using SupplierTestApp.Domain.Entities;

namespace SupplierTestApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Supplier> Supplier { get; set; }
        DbSet<SupplierRate> SupplierRate { get; set; }
    }
}
