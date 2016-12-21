using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class rootcanal
    {
       public rootcanal()
       {
           rootcanalid= new HashSet<person_rootcanal>();
           subrootid=new HashSet<subroot>();
       }
        public int Id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public ICollection<person_rootcanal> rootcanalid { get; set; }
        public ICollection<subroot> subrootid { get; set; }
    }
}
