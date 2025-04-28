using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Administrator
    {
        public int AdminId { get; set; }
        public string Name { get; set; }



        public List<Member> ManagedMembers { get; set; } = new();
        public List<Boat> ManagedBoats { get; set; } = new();
    }
}
