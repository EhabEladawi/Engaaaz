using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class extraction
    {
        public extraction()
        {
            extractionid = new HashSet<person_extraction>();
        }
        public int Id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }

        public ICollection<person_extraction> extractionid { get; set; }

       
    }
}
