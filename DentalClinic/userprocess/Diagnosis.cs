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
    public partial class Diagnosis : MetroFramework.Forms.MetroForm
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                List<DAL.process> ctxx = ctx.process.Where(pro => pro.id == 1).ToList();
                DAL.process pros = ctxx[0];
                pros.Money = textBox1.Text;
                ctx.SaveChanges();
                MessageBox.Show("Data Updated.. ");
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
              using (DAL.MyContext ctx = new DAL.MyContext())
            {
               textBox1.Text  = (ctx.process.Where(u => u.id == 1).Select(u => u.Money)).FirstOrDefault();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

