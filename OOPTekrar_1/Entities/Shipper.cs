using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Shipper
    {
        public string ShipperName { get; set; }

        //relational properties
        public virtual List<Order> Orders { get; set; }
    }
}
