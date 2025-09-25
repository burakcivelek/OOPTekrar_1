using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class Supplier
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
 
        //relational properties
        public virtual List<Product> Products { get; set; }
    }
}
