using Inventory.Domain.Entities.Categories;
using Inventory.Domain.Entities.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities.Products {
    public class Product {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public int CategoryId { get; set; } // => fK
        public Category Category { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }


    }
}
