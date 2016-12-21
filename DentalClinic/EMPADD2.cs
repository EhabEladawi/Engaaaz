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
    public partial class EMPADD2 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public EMPADD2()
        {
            InitializeComponent();
        }

        private void EMPADD2_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.comboBox1.DataSource = ctx.Gender.Select(doc => new { sex = doc.sex, id = doc.id }).ToList();
                comboBox1.DisplayMember = "sex";
                comboBox1.ValueMember = "id";
            }
            txttele.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtcv.Text = @"EMPcv\" +openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.ShowDialog();
                txtpic.Text = @"EMPpic\" + lblid.Text;
                Bitmap myBitmap = new Bitmap(openFileDialog2.FileName);

                myBitmap.Save(@"EMPpic\" + lblid.Text);
                pictureBox1.ImageLocation = @"EMPpic\" + lblid.Text;
            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lblid.Text);
            using (DAL.MyContext ctx = new DAL.MyContext())
            {

                DAL.EmpPersonal emp = new DAL.EmpPersonal();


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

                ctx.EmpPersonal.Add(emp);

                ctx.SaveChanges();
                MessageBox.Show("Data inserted  ");
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtidnum.Text = "";
            txtcv.Text = txtmail.Text = txtmobile.Text = txtmobile2.Text = txtpic.Text = txttele.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EMPADD3 emp = new EMPADD3();
            id = Convert.ToInt32(lblid.Text);

            this.Hide();
            emp.ShowDialog();
           
        }
    }
}
