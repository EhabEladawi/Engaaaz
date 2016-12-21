using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_dentalraidiology
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofdentalbleeching { get; set; }
        public dentalraidiology dentalraidiologyid { get; set; }
        public int dentalraidiologyidFK { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
    }
}
