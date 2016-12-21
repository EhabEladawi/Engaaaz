using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class dentalraidiology
    {
        public dentalraidiology()
        {
            dentalbleechingid = new HashSet<person_dentalraidiology>();
        }
        public int Id { get; set; }
        public int name { get; set; }
        public int cost { get; set; }

        public ICollection<person_dentalraidiology> dentalbleechingid { get; set; }
    }
}
