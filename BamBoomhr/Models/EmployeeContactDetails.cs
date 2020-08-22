using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeContactDetails
    {

        public int Id { get; set; }
        public string HomeTelephone { get; set; }
        public string Mobile { get; set; }
        public string WorkTelephone { get; set; }
        public string WorkEmail { get; set; }
        public string OtherEmail { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
