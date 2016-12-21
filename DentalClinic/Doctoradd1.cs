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
    public partial class Doctoradd1 : MetroFramework.Forms.MetroForm
    {
        public Doctoradd1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = txtpass.Text = txtconfirmpass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text!= string.Empty)
            {
                if (txtpass.Text == txtconfirmpass.Text)
                {
                    using (DAL.MyContext  ctx = new DAL.MyContext())
                    {

                        DAL.Doctors doc = new DAL.Doctors();
                        doc.name = txtname.Text;
                        doc.password = txtpass.Text;
                        ctx.Doctors.Add(doc);
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

        private void txtconfirmpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==  (char) Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
