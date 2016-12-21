using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class person_subsubdentalprothesis
    {

        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofsubsubdentalprothesis { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
        public subsubdentalprothesis subsubdentalprothesisid { get; set; }
        public int subsubdentalprothesisidFK { get; set; }

    }
}
