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
    public partial class EMPADD1 : MetroFramework.Forms.MetroForm
    {
        public EMPADD1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = txtpass.Text = txtconfirmpass.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty)
            {
                if (txtpass.Text == txtconfirmpass.Text)
                {
                    using (DAL.MyContext ctx = new DAL.MyContext())
                    {

                        DAL.EMP emp = new DAL.EMP();
                        emp.name = txtname.Text;
                        emp.password = txtpass.Text;
                        ctx.EMP.Add(emp);
                        ctx.SaveChanges();
                        MessageBox.Show("Data inserted  ");
                        button2.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Password is not matched");
                }
            }
            else
            {
                MessageBox.Show("Username is empity ");
            }
        }
    }
}
