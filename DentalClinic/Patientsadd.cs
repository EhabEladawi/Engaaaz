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
    public partial class Patientsadd : MetroFramework.Forms.MetroForm
    {
        public Patientsadd()
        {
            InitializeComponent();
        }

        private void Patientsadd_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.cbg.DataSource = ctx.Gender.Select(doc => new { sex = doc.sex, id = doc.id }).ToList();
                cbg.DisplayMember = "sex";
                cbg.ValueMember = "id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {

                DAL.personcs per = new DAL.personcs();
                per.name = txtfname.Text + " " + txtlname.Text;
                per.sexFK = (int)cbg.SelectedValue;
                per.mobile = txtmob.Text;
                per.mobile2 = txtmob2.Text;
                per.telephone = txtte.Text;
                per.Marital_status = cbms.Text;
                per.address = txtadd.Text;
                per.Dateofbirth = Convert.ToDateTime(dtpdate.Text);
                

                ctx.Person.Add(per);

                ctx.SaveChanges();
                MessageBox.Show("Data inserted  ");
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Text = txtlname.Text = txtmob.Text = txtmob2.Text = txtte.Text = string.Empty;
            cbg.Text = cbms.Text = string.Empty;
            dtpdate.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
