using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class resroration
    {
       public resroration()
       {
           resrorationid = new HashSet<person_resroration>();
       }
        public int Id { get; set; }
        public string name { get; set; }
        public int coast { get; set; }

        public ICollection<person_resroration> resrorationid { get; set; }
    }
}
