using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.Model
{
    public class Licit : Entity
    {
        public virtual Gadget Gadget { get; set; }
        public virtual User User { get; set; }
        public int Value { get; set; }
    }
}
