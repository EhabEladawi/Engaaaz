using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class subsubdentalprothesis
    {

        public subsubdentalprothesis()
        {
            subsubdentalprothesisid = new HashSet<person_subsubdentalprothesis>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public subdentalprothesis subdentalprothesisid { get; set; }
        public int subdentalprothesisidFK { get; set; }
        public ICollection<person_subsubdentalprothesis> subsubdentalprothesisid { get; set; }
    }
}
