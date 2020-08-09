using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string Province { get; set; }
        public Municipality Municipality { get; set; }
    }
}
