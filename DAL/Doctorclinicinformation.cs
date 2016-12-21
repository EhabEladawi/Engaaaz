using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Doctorclinicinformation
    {
        public int Id { get; set; }
        public int Ratio { get; set; }
        public string Filepath { get; set; }

        public DateTime dateofhire { get; set; }
        public int doctoridFK { get; set; }
        public Doctors doctorid { get; set; }

    }
}
