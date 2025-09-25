using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class ProductAppAttribute
    {
        public int ProductId { get; set; }
        public int AppAttributeId { get; set; }

        //relational properties
        public virtual Product Product { get; set; }
        public virtual AppAttribute AppAttribute { get; set; }
    }
}
