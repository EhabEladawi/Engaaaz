using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class doctorscientific
    {
        public int Id { get; set; }


        public string dateofgru { get; set; }
        public string graide { get; set; }
        public string department { get; set; }
        public string workat { get; set; }
        public int doctoridFK { get; set; }
        public Doctors doctorid { get; set; }
    }
}
