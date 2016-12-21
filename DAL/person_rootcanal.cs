using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class person_rootcanal
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofrootcanal { get; set; }
        public rootcanal rootcanalid { get; set; }
        public int rootcanalidFK { get; set; }
        public personcs Personsid { get; set; }
        public int PersonsidFK { get; set; }
    }
}
