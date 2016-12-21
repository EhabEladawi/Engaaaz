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
    public partial class EMPManage1 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public EMPManage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lblid.Text);
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                List<DAL.EMP> ctxx = ctx.EMP.Where(emp => emp.Id == id).ToList();
                DAL.EMP EMps = ctxx[0];
                EMps.name = txtname.Text;
                EMps.password = txtpass.Text;
                ctx.SaveChanges();
                MessageBox.Show("Data Updated.. ");
                id = Convert.ToInt32(lblid.Text);
                dataGridView1.DataSource = ctx.EMP.Where(emp => emp.Id == id).ToList();
                txtname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txtpass.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = txtpass.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMPManage2 doc = new EMPManage2();
            doc.lblid.Text = lblid.Text;
            this.Hide();
            doc.ShowDialog();
        }

        private void EMPManage1_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lblid.Text);
            try
            {
                id = Convert.ToInt32(lblid.Text);
                using (DAL.MyContext ctx = new DAL.MyContext())
                {
                    dataGridView1.DataSource = ctx.EMP.Where(doc => doc.Id == id).ToList();
                    txtname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtpass.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
