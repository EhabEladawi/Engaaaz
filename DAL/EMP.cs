using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EMP
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public ICollection<EmpPersonal> EmpPersonalid { get; set; }
        public ICollection<EMPClinic> EMPClinicid { get; set; }
        public EMP()
        {
            EmpPersonalid = new HashSet<EmpPersonal>();
            EMPClinicid = new HashSet<EMPClinic>();

        }
    }
}
