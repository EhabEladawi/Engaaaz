using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EMPClinic
    {
        public int Id { get; set; }
        public int Ratio { get; set; }
        public string Filepath { get; set; }
        public int hiresalary { get; set; }
        public DateTime dateofhire { get; set; }
        public int EMPIDFK { get; set; }
        public EMP EMPid { get; set; }


    }
}
