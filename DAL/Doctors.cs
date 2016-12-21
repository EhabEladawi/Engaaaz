using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Doctors
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public ICollection<Doctrorpersonal> Doctrorpersonalid { get; set; }
        public ICollection<doctorscientific> doctorscientificid { get; set; }
        public ICollection<Doctorclinicinformation> Doctorclinicinformationid { get; set; }
        public Doctors()
        {
            Doctorclinicinformationid = new HashSet<Doctorclinicinformation>();
            doctorscientificid = new HashSet<doctorscientific>();
            Doctrorpersonalid = new HashSet<Doctrorpersonal>();

        }
    }
}
