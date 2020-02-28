using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalInformationSystem.Models
{
    public class Patient: Entity
    {
        public Patient()
        {
            RecordCreationDate = DateTime.Now;
        }

        [Required]
        public string Name { get; set; }
        public int FileNo { get; set; }
        [Required]
        public string CitizenId { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public DateTime? FirstVisitDate { get; set; }
        public DateTime? RecordCreationDate { get; set; }
    }
}
