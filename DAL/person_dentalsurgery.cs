using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_dentalsurgery
    {
        public int Id { get; set; }
        public DateTime dateofdentalsurgery { get; set; }
        public int cost { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
        public dentalsurgery dentalsurgeryid { get; set; }
        public int dentalsurgeryidFK { get; set; }

    }
}
