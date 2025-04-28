using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BoatBooking
    {
        public int BookingId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Destination { get; set; }
        public Member BookedBy { get; set; }
        public Boat Boat { get; set; }
    }
}
