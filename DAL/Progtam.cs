using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Progtam
    {
        public static void Main()
        {
            using (MyContext ctx = new MyContext())
            {
                //gendercs g = new gendercs();
                //g.sex = "Male";
                
                //ctx.Gender.Add(g);
                //ctx.SaveChanges();
                //g.sex = "Female";

                //ctx.Gender.Add(g);
                //ctx.SaveChanges();
            }

        }
    }
}
