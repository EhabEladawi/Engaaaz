using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public    class person_dentalprothesis
    {
        public int Id { get; set; }
        public int cost { get; set; }
        public DateTime dateofdentalprothesis { get; set; }
        public personcs personid { get; set; }
        public int personidFK { get; set; }
        public dentalprothesis dentalprothesisid { get; set; }
        public int dentalprothesisidFK { get; set; }
    }
}
