using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.Model
{
    public class Gadget : Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Start_licit { get; set; }
        public virtual ICollection<Licit> Licits { get; set; }
        public Gadget()
        {
            Licits = new HashSet<Licit>();
        }
    }
}
