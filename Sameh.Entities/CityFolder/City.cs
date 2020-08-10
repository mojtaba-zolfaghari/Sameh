using Sameh.Entities.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
    public class City : BaseEntity
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public Entities.City.Town Town { get; set; }
        public Province Province { get; set; }
        public Organization Organization { get; set; }
        public Municipality Municipality { get; set; }
    }
}
