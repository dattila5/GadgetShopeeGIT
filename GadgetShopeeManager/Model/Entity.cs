using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.Model
{
    public class Entity
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
    }
}
