using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public   class subdentalprothesis
    {

        public int Id { get; set; }
        public int cost { get; set; }
        public string name { get; set; }
        public dentalprothesis  dentalprothesisid { get; set; }
        public int dentalprothesisidFK { get; set; }
        public ICollection<person_subdentalprothesis> subdentalprothesisid { get; set; }
        public ICollection<subsubdentalprothesis> subsubdentalprothesis { get; set; }
        public subdentalprothesis()
        {
            subdentalprothesisid = new HashSet<person_subdentalprothesis>();
            subsubdentalprothesis = new HashSet<subsubdentalprothesis>();
        }
    }
}
