using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public    class dentalprothesis
    {

        public dentalprothesis()
        {
            persondentalprothesisid = new HashSet<person_dentalprothesis>();

        }
        public int Id { get; set; }
        public string  name { get; set; }
        public int  cost { get; set; }


        public ICollection<person_dentalprothesis> persondentalprothesisid { get; set; }
        public ICollection<subsubdentalprothesis> subsubdentalprothesisid { get; set; }
    }
}
