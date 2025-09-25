using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar_1.Entities
{
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //relational properties
        public virtual AppUserProfile AppUserProfile { get; set; }
    }
}
