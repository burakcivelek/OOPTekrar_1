using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Models
{
    public class Category
    {
        public Category(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
            Products = new List<Product>();
        }

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; } 
    }
}
