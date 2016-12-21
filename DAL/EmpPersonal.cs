using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EmpPersonal
    {

        public int Id { get; set; }
        public gendercs sex { get; set; }

        public int sexidFK { get; set; }
        public string telephone { get; set; }
        public string Mobile { get; set; }
        public string mobile2 { get; set; }
        public string idnumber { get; set; }
        public string email { get; set; }
        public string cvpath { get; set; }
        public string imagepath { get; set; }
        public DateTime dateofbirth { get; set; }
        public EMP Empid { get; set; }
        public int EMPIDFK { get; set; }
    }
}

