using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_subroot
    {
        public int Id { get; set; }
        public int coast { get; set; }
        public DateTime dateofsubroot { get; set; }
        public rootcanal rootcanalid { get; set; }
        public int rootcanalidFK { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
        public subroot FKsubroot_id { get; set; }
        public int subroot_idFK { get; set; }
    }
}
