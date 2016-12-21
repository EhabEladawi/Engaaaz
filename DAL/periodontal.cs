using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class periodontal
    {
        public periodontal()
        {
            periodontalid = new HashSet<person_periodontal>();
        }
        public int Id { get; set; }
        public int name { get; set; }
        public int cost { get; set; }

        public ICollection<person_periodontal> periodontalid { get; set; }
    }
}
