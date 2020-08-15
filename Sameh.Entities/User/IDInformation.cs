using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class IDInformation
    {
        public int Id { get; set; }
        public string NationalCode { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }
        public string placeOfBirth { get; set; }
        public string IDNumber { get; set; }
        public GenderType Gender { get; set; }
        public BaseUser BaseUser { get; set; }
    }
}
