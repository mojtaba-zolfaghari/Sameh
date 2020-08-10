using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{

   public class Town:BaseEntity
    { 
        public int TownId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Town> Cities { get; set; }

    }
}
