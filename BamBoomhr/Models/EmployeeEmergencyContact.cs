using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeEmergencyContact
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string HomeTelephone { get; set; }
        public string Mobile { get; set; }
        public string WorkTelephone { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
