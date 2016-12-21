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
    public partial class docmanage2 : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public docmanage2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Docotrmanage3 doc = new Docotrmanage3();
            doc.lblid.Text = lblid.Text;
            this.Hide();
            doc.ShowDialog();
            
        }

        private void docmanage2_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = ctxx.Doctrorpersonal.Where(doc => doc.DoctoridFK == id).ToList();
                try
                {
                    txttele.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtmobile.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtmobile2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    txtmail.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    txtpic.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    txtcv.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    dtpbirth.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[9].Value.ToString());
                    comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                    
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
                List<DAL.Doctrorpersonal> docupdate = ctx.Doctrorpersonal.Where(docsss => docsss.DoctoridFK == id).ToList();
                DAL.Doctrorpersonal doc = docupdate[0];
                doc.telephone = txttele.Text;
                doc.Mobile = txtmobile.Text;
                doc.mobile2 = txtmobile2.Text;
                doc.sexidFK = (int)comboBox1.SelectedValue;
                doc.dateofbirth = dtpbirth.Value;
                doc.cvpath = txtcv.Text;
                doc.imagepath = txtpic.Text;
                doc.DoctoridFK = Convert.ToInt32(lblid.Text);
                doc.email = txtmail.Text;

                ctx.SaveChanges();
                MessageBox.Show("Data updated ..");
                dataGridView1.DataSource = ctx.Doctrorpersonal.Where(docss => docss.DoctoridFK == id).ToList();
                try
                {
                    txttele.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtmobile.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtmobile2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    txtmail.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    txtpic.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    txtcv.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    dtpbirth.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[9].Value.ToString());
                    comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                    pictureBox1.ImageLocation = txtpic.Text;
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

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtcv.Text = @"Doctorcv\" + openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.ShowDialog();
                txtpic.Text = @"Doctorpic\" + lblid.Text;
                Bitmap myBitmap = new Bitmap(openFileDialog2.FileName);

                myBitmap.Save(@"Doctorpic\" + lblid.Text);
                pictureBox1.ImageLocation = @"Doctorpic\" + lblid.Text;
            }
            catch (Exception)
            {


            }
        }
    }
}
