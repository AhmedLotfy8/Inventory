using Inventory.Domain.Entities.Employees;
using Inventory.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities.Transactions {

    public enum TransactionType {

        Sale = 0,
        Purchase = 1

    }

    public class Transaction {

        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }


    }

}
