using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class Address
    {
        public int Id { get; set; }
        public string MainStreet { get; set; }
        public string AuxiliaryRoad { get; set; }
        public string Alley { get; set; }
        public string Plaque { get; set; }
        public int Floor { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string ZipCode { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public BaseUser User { get; set; }
    }
}
