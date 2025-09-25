using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Order
    {
        public string ShippingAdress { get; set; }
        public int? ShipperId { get; set; }
        public int? SupplierId { get; set; }
        public int? AppUserId { get; set; }

        //relational properties
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
