using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierTestApp.Application.Common.Interfaces
{
    public interface ISupplierService
    {
        object GetAll();
        object GetSupplierOverlaps(int? SupplierNumber);
    }
}
