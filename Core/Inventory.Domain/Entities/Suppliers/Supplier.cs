using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities.Suppliers {
    public class Supplier {
    
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }


        // !!!!!
        public string PerformanceMetrics { get; set; }


    }
}
