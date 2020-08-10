using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public Town Town { get; set; }
        public Province Province { get; set; }
        public Organization Organization { get; set; }
        public Municipality Municipality { get; set; }
    }
}
