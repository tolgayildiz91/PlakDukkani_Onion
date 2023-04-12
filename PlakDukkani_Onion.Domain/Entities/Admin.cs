using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Domain.Entities
{
    public class Admin:User
    {
        public User User { get; set; }
    }
}
