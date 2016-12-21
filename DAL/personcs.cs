using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class personcs
    {
        public personcs()
        {
            diagonsis = new HashSet<person_diagnosis>();
            extraction = new HashSet<person_extraction>();
            resroration = new HashSet<person_resroration>();
            rootcanal= new HashSet<person_rootcanal>();
            subroot=new HashSet<person_subroot>();
            periodontalid = new HashSet<person_periodontal>();
            dentalbleeching = new HashSet<person_dentalbleeching>();
            dentalraidiologyid = new HashSet<person_dentalraidiology>();
            dentalprothesisid = new HashSet<person_dentalprothesis>();
            subdentalprothesisid = new HashSet<person_subdentalprothesis>();
            subsubdentalprothesisid = new HashSet<person_subsubdentalprothesis>();
            dentalsurgeryid = new HashSet<person_dentalsurgery>();
            histrorypersonid = new HashSet<medicalhistroryperson>();



        }

        public int Id { get; set; }
        public string name { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string mobile2 { get; set; }
        public int FKgender { get; set; }
        public string Marital_status { get; set; }
        public gendercs sex { get; set; }
        public int sexFK { get; set; }

        public ICollection<person_diagnosis> diagonsis { get; set; }
        public ICollection<person_extraction> extraction { get; set; } 
        public ICollection<person_resroration> resroration { get; set; }
        public ICollection<person_rootcanal> rootcanal{ get; set; }
        public ICollection<person_subroot> subroot { get; set; }
        public ICollection<person_periodontal> periodontalid { get; set; }
        public ICollection<person_dentalbleeching> dentalbleeching { get; set; }

        public ICollection<person_dentalraidiology> dentalraidiologyid { get; set; }
        public ICollection<person_dentalprothesis> dentalprothesisid { get; set; }

        public ICollection<person_subdentalprothesis> subdentalprothesisid   { get; set; }
        public ICollection<person_subsubdentalprothesis> subsubdentalprothesisid { get; set; }

        public ICollection<person_dentalsurgery> dentalsurgeryid { get; set; }
        public ICollection<medicalhistroryperson> histrorypersonid { get; set; }

    }
}
