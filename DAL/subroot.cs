using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class subroot
    {
       public subroot()
       {
            subrootid=new HashSet<person_subroot>();
       }
        public int Id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public rootcanal canalid { get; set; }
        public int canalidFK { get; set; }

        public ICollection<person_subroot> subrootid { get; set; }
    }
}
