using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dentalbleeching
    {
        public dentalbleeching()
        {
            dentalbleechingid = new HashSet<person_dentalbleeching>();
        }
        public int Id { get; set; }
        public int name { get; set; }
        public int cost { get; set; }

        public ICollection<person_dentalbleeching> dentalbleechingid { get; set; }
    }
}
