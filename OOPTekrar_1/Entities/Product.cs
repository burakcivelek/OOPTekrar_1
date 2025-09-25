using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        //relational properties,
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; } 
        public virtual Supplier Supplier { get; set; }
    }
}
