using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.userprocess
{
    public partial class pocket_injection : MetroFramework.Forms.MetroForm
    {
        public pocket_injection()
        {
            InitializeComponent();
        }

        private void pocket_injection_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                textBox1.Text = (ctx.process.Where(u => u.id == 30).Select(u => u.Money)).FirstOrDefault();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                List<DAL.process> ctxx = ctx.process.Where(pro => pro.id == 30).ToList();
                DAL.process pros = ctxx[0];
                pros.Money = textBox1.Text;
                ctx.SaveChanges();
                MessageBox.Show("Data Updated.. ");
            }
        }
    }
}
