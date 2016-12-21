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
    public partial class EMPManage2 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public EMPManage2()
        {
            InitializeComponent();
        }

        private void EMPManage2_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.comboBox1.DataSource = ctx.Gender.Select(doc => new { sex = doc.sex, id = doc.id }).ToList();
                comboBox1.DisplayMember = "sex";
                comboBox1.ValueMember = "id";
            }
            id = Convert.ToInt32(lblid.Text);
            using (DAL.MyContext ctxx = new DAL.MyContext())
            {
                id = Convert.ToInt32(lblid.Text);
                dataGridView1.DataSource = ctxx.EmpPersonal.Where(Emp => Emp.EMPIDFK == id).ToList();
                try
                {
                    txttele.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtmobile.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtmobile2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    txtmail.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    txtpic.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    txtcv.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
                    txtidnum.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();

                    dtpbirth.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[10].Value.ToString());
                    comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.Rows[0].Cells[11].Value.ToString());
                    pictureBox1.ImageLocation = txtpic.Text;
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
                List<DAL.EmpPersonal> emppersonal = ctx.EmpPersonal.Where(emps => emps.EMPIDFK == id).ToList();
                DAL.EmpPersonal emp = emppersonal[0];
                emp.telephone = txttele.Text;
                emp.Mobile = txtmobile.Text;
                emp.mobile2 = txtmobile2.Text;
                emp.sexidFK = (int)comboBox1.SelectedValue;
                emp.dateofbirth = dtpbirth.Value;
                emp.cvpath = txtcv.Text;
                emp.imagepath = txtpic.Text;
                emp.EMPIDFK = Convert.ToInt32(lblid.Text);
                emp.email = txtmail.Text;
                emp.idnumber = txtidnum.Text;

                ctx.SaveChanges();
                MessageBox.Show("Data updated ..");
                dataGridView1.DataSource = ctx.EmpPersonal.Where(emps => emps.EMPIDFK == id).ToList();
                try
                {
                    txttele.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtmobile.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtmobile2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtmail.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    txtpic.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    txtcv.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    dtpbirth.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[9].Value.ToString());
                    comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.Rows[0].Cells[11].Value.ToString());
                    pictureBox1.ImageLocation = txtpic.Text;
                    txtidnum.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                }
                catch (Exception)
                {


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EMPManage3 doc = new EMPManage3();
            doc.lblid.Text = lblid.Text;
            this.Hide();
            doc.ShowDialog();
        }
    }
}
