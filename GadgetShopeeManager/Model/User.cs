using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.Model
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Licit> Licits { get; set; }
        public User()
        {
            Licits = new HashSet<Licit>();
        }
    }
}
