using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   
    
        public class Member
        {
            public int MemberId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool IsActive { get; set; }  

            public List<BoatBooking> Bookings { get; set; } = new();
            public List<EventRegistration> Registrations { get; set; } = new();
        }
    
}
