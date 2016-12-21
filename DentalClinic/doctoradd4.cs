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
    public partial class doctoradd4 : MetroFramework.Forms.MetroForm
    {
        public doctoradd4()
        {
            InitializeComponent();
        }

        private void doctoradd4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                DAL.Doctorclinicinformation doc = new DAL.Doctorclinicinformation();
                doc.doctoridFK = Convert.ToInt32(lblid.Text);
                doc.Ratio = Convert.ToInt32(txtpre.Text);
                doc.dateofhire = dateTimePicker1.Value;
                ctx.Doctorclinicinformation.Add(doc);
                ctx.SaveChanges();
                MessageBox.Show("data inserted");
                button2.PerformClick();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctorselect doc = new Doctorselect();
            
            this.Hide();
            doc.ShowDialog();
        }
    }
}
