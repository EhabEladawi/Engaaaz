using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class diagnosis
    {
       public diagnosis()
       {
           diagosis = new HashSet<person_diagnosis>();
       }
        public int id { get; set; }
        public int cost { get; set; }

        public ICollection<person_diagnosis> diagosis { get; set; }
    }
}
