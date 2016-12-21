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
    public partial class Docotrmanage3 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public Docotrmanage3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Docmanage4 doc = new Docmanage4();
            doc.lblid.Text = lblid.Text;
            doc.ShowDialog();
            this.Hide();
        }

        private void Docotrmanage3_Load(object sender, EventArgs e)
        {
             id = Convert.ToInt32(lblid.Text);

            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                dataGridView1.DataSource = ctx.doctorscientific.Where(doc => doc.doctoridFK == id).ToList();
                try
                {
                    txtgrad.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    comboBox1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtwork.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

                }
                catch (Exception)
                {


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                List<DAL.doctorscientific> doclist = ctx.doctorscientific.Where(doc => doc.doctoridFK == id).ToList();
                try
                {
                    DAL.doctorscientific docupdate = doclist[0];

                    docupdate.dateofgru = txtgrad.Text;
                    docupdate.graide = comboBox1.Text;
                    docupdate.workat = txtwork.Text;
                    ctx.SaveChanges();
                    MessageBox.Show("Data Updated... ");

                    
                        dataGridView1.DataSource = ctx.doctorscientific.Where(doc => doc.doctoridFK == id).ToList();
                        try
                        {
                            txtgrad.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                            comboBox1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                            txtwork.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

                        }
                        catch (Exception)
                        {


                        }
                    

                }
                catch (Exception)
                {


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}