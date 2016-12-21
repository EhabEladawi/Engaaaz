using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_resroration
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofextraction { get; set; }

        public resroration extraction { get; set; }
        public int extractionFK { get; set; }

        public personcs personid { get; set; }
        public int personidFK { get; set; }
    }
}
