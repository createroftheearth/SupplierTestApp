using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierTestApp.Domain.Entities
{
    public class SupplierRate
    {
        [Key]
        public int SupplierRateId { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierNumber { get; set; }
        public int Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
