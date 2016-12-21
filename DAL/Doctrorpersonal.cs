using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class Doctrorpersonal
    {
        public int Id { get; set; }
        public gendercs sexid { get; set; }
        public int sexidFK { get; set; }
        public string telephone { get; set; }
        public string Mobile { get; set; }
        public string mobile2 { get; set; }

        public string email { get; set; }
        public string imagepath { get; set; }
        public string cvpath { get; set; }
        public DateTime  dateofbirth { get; set; }
        public int DoctoridFK { get; set; }
        public Doctors doctorid { get; set; }
    }
}
