using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierTestApp.Domain.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierNumber { get; set; }
        [MaxLength(50)]
        public string SupplierName { get; set; }

        public virtual List<SupplierRate> FK_SupplierRate { get; set; }
    }
}
