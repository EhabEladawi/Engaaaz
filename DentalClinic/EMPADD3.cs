using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class EMPADD3 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public EMPADD3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                DAL.EMPClinic emp = new DAL.EMPClinic ();
                emp.EMPIDFK = Convert.ToInt32(lblid.Text);
                emp.Ratio = Convert.ToInt32(txtpre.Text);
                emp.dateofhire = dateTimePicker1.Value;
                emp.hiresalary = Convert.ToInt32(txtsalalry.Text);
                ctx.EMPClinic.Add(emp);
                ctx.SaveChanges();
                MessageBox.Show("data inserted");
                button2.PerformClick();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpre.Text=txtsalalry.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
