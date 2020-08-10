using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class Municipality: BaseEntity
    {
        public string Name { get; set; }
        public string NaionalCode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string RegistrationNumber { get; set; }
        public bool IsEnabled { get; set; }
        public MunicipalityAddress  MunicipalityAddress { get; set; }
        public virtual ICollection<Mayor> Mayors { get; set; }
    }
   public class MunicipalityAddress
    {
        public string ZipCode { get; set; }
        public virtual Province Province { get; set; }
        public virtual City City { get; set; }
        public virtual Town Town { get; set; }
        public string MainStreet { get; set; }
        public string AuxiliaryRoad { get; set; }
        public string Alley { get; set; }
        public string Plaque { get; set; }
        public string Description { get; set; }

    }

}
