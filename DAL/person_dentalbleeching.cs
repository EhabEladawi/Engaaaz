using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_dentalbleeching
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofdentalbleeching { get; set; }
        public dentalbleeching dentalbleechingid { get; set; }
        public int dentalbleechingidFK { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
    }
}
