using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClubEvent
    {
        public int EventId { get; set; }
        public string Title { get; set; } // e.g. "Summer Party"
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int MaxParticipants { get; set; }
        public List<EventRegistration> Registrations { get; set; } = new();
    }
}
