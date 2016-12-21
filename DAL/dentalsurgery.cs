using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class dentalsurgery
    {
        public int ID { get; set; }
        public int cost { get; set; }
        public string name { get; set; }


        public ICollection<person_dentalsurgery> dentalsurgeryid { get; set; }
        public dentalsurgery()
        {
            dentalsurgeryid = new HashSet<person_dentalsurgery>();
        }
    }
}
