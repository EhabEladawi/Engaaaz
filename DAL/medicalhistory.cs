using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class medicalhistory
    {
        public int Id  { get; set; }
        public String Name { get; set; }

        public ICollection<medicalhistroryperson> medicalhistrorypersonid { get; set; }

        public medicalhistory()
        {
            medicalhistrorypersonid = new HashSet<medicalhistroryperson>();
        }
    }
}
