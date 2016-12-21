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
    public partial class doctoradd3 : MetroFramework.Forms.MetroForm
    {
        public doctoradd3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtgrad.Text = "";
            txtwork.Text = "";
            listBox1.ClearSelected();
            comboBox1.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                
                foreach (object item in listBox1.SelectedItems)
                {
                    DAL.doctorscientific doc = new DAL.doctorscientific();
                    doc.doctoridFK = Convert.ToInt32(lblid.Text);
                    doc.workat = txtwork.Text;
                    doc.dateofgru = txtgrad.Text;
                    doc.graide = comboBox1.Text;
                    doc.department = item.ToString() ;
                    ctx.doctorscientific.Add(doc);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Data inserted");
                button2.PerformClick();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doctoradd4 doc = new doctoradd4();
            doc.lblid.Text = this.lblid.Text;
           
            this.Hide();
            doc.ShowDialog();
        }

        private void doctoradd3_Load(object sender, EventArgs e)
        {

        }
    }
}
