using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using SupplierTestApp.Application.Common.Interfaces;
using SupplierTestApp.Infrastructure;

namespace SupplierTestApp.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly IApplicationDbContext _context;
        public SupplierService(IApplicationDbContext context)
        {
            _context = context;
        }
        public object GetAll()
        {
            return _context.Supplier.Select(z => new
            {
                z.SupplierNumber,
                Rates = z.FK_SupplierRate.Select(z => z.Rate).ToList()
            }).ToList();
        }

        public object GetSupplierOverlaps(int? SupplierNumber)
        {
            return (from sup in _context.SupplierRate
                    join sup2 in _context.SupplierRate on sup.SupplierNumber equals sup2.SupplierNumber
                    where (sup.SupplierNumber == SupplierNumber || SupplierNumber == null)
                    && (sup.StartDate <= sup2.StartDate && sup2.StartDate <= sup.EndDate) && sup.Rate != sup2.Rate
                    select new
                    {
                       sup.SupplierNumber,
                       Rate = sup.Rate > sup2.Rate ? sup.Rate:sup2.Rate,
                       sup.StartDate,
                       sup2.EndDate
                    }).ToList();
        }
    }
}
