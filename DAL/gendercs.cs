using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class gendercs
    {
        public gendercs()
        {
            persons = new HashSet<personcs>();
            Doctrorpersonalid = new HashSet<Doctrorpersonal>();
            EmpPersonalid=new HashSet<EmpPersonal>();
        }
        public int id { get; set; }
        public string sex { get; set; }

        public ICollection<personcs> persons { get; set; }
        public ICollection<Doctrorpersonal> Doctrorpersonalid { get; set; }

        public ICollection<EmpPersonal> EmpPersonalid { get; set; }
    }
}
