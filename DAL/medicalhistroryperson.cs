using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class medicalhistroryperson
    {
        public int Id { get; set; }
        public medicalhistory medicalid { get; set; }
        public int medicalidfk { get; set; }
        public personcs personid { get; set; }
        public int personidfk { get; set; }
    }
}
