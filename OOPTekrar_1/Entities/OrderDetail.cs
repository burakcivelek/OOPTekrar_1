using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        //relational properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
