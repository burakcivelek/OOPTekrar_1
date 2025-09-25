using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Models
{
    public class Product
    {
        public string ProductName { get; set; }

        decimal _unitPrice;
        public decimal UnitPrice {
            get
            {
                return _unitPrice;

            } 
            set
            {
                if (value < 10)
                {
                    throw new Exception("Lutfen 10'dan buyuk deger giriniz");
                }

                _unitPrice = value;
            }
        }
        public Category Category { get; set; }
    }
}
