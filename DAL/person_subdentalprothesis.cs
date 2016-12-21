using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class person_subdentalprothesis
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofsubsentalprothesis { get; set; }
        public subdentalprothesis subdentalprothesisid { get; set; }
        public int subdentalprothesisidFK { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
    }
}
