using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EventRegistration
    {
        public int RegistrationId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Member Member { get; set; }
        public ClubEvent Event { get; set; }
    }
}
