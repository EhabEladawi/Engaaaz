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
    public partial class EMPManage3 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public EMPManage3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EMPManage3_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lblid.Text);

            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                dataGridView1.DataSource = ctx.EMPClinic.Where(emp => emp.EMPIDFK == id).ToList();
                try
                {
                    //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value.ToString());
                    txtpre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txtsalalry.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
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
                List<DAL.EMPClinic> emp = ctx.EMPClinic.Where(emps => emps.EMPIDFK == id).ToList();
                try
                {
                    DAL.EMPClinic empupdate = emp[0];
                    empupdate.hiresalary = Convert.ToInt32(txtsalalry.Text);
                    empupdate.Ratio = Convert.ToInt32(txtpre.Text);
                    ctx.SaveChanges();
                    MessageBox.Show("Data Updated... ");
                    dataGridView1.DataSource = ctx.Doctorclinicinformation.Where(doc => doc.doctoridFK == id).ToList();
                    try
                    {
                        //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value.ToString());
                        txtpre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        txtsalalry.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

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
    }
}
