using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_periodontal
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofperiodontal { get; set; }
        public periodontal FKperiodontalid { get; set; }
        public int periodontalidFK { get; set; }
        public personcs personalid { get; set; }
        public int personalidFK { get; set; }

    }
}
