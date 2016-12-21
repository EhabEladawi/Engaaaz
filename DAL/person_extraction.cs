using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_extraction
    {
        public int Id { get; set; }
        public int coast { get; set; }
        public DateTime dateofextraction { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
        public extraction extractionid { get; set; }
        public int extractionidFK { get; set; }
    }
}
