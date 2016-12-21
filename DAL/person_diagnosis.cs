using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_diagnosis
    {
        public int ID { get; set; }
        public int cost { get; set; }
        public diagnosis digagonsis { get; set; }
        public int digagonsisFK { get; set; }
        public DateTime dateofdiagosis { get; set; }

        public personcs FKpersonid { get; set; }

        public int personidFK { get; set; }

    }
}
