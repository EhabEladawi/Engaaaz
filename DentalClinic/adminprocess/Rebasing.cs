using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.adminprocess
{
    public partial class Rebasing : MetroFramework.Forms.MetroForm
    {
        public Rebasing()
        {
            InitializeComponent();
        }

        private void Rebasing_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                textBox1.Text = (ctx.process.Where(u => u.id == 36).Select(u => u.Money)).FirstOrDefault();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                List<DAL.process> ctxx = ctx.process.Where(pro => pro.id == 36).ToList();
                DAL.process pros = ctxx[0];
                pros.Money = textBox1.Text;
                ctx.SaveChanges();
                MessageBox.Show("Data Updated.. ");
            }
        }
    }
}
