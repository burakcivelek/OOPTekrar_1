using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class AppAttribute
    {
        public string Attribute { get; set; }

        //relational properties
        public virtual List<ProductAppAttribute> ProductAppAttributes { get; set; } 
    }
}
