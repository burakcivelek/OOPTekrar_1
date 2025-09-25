using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Models
{
    public class Karakter
    {
        public Karakter(string isim, int seviye, int can)
        {
            Isim = isim;
            Seviye = 1;
            if (can < 100)
            {
                Can = 100;
            }
            else
            {
                Can = can;
            }

        }

        public string Isim { get; set; }
        public int Seviye { get; private set; }
        public int Can { get; set; }

        public void SeviyeAta(int seviye)
        {
            Seviye = seviye;
        }

    }

}
