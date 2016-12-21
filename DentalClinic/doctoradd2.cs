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
    public partial class doctoradd2 : MetroFramework.Forms.MetroForm
    {
        public doctoradd2()
        {
            InitializeComponent();
        }

        private void doctoradd2_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.comboBox1.DataSource=ctx.Gender.Select(doc => new {sex=doc.sex , id = doc.id  }).ToList();
                comboBox1.DisplayMember = "sex";
                comboBox1.ValueMember = "id";
            }
            txttele.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtcv.Text =@"Doctorcv\"+openFileDialog1.FileName;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.ShowDialog();
                txtpic.Text = @"Doctorpic\" + lblid.Text  ;
                Bitmap myBitmap = new Bitmap(openFileDialog2.FileName);

                myBitmap.Save(@"Doctorpic\" + lblid.Text  );
                pictureBox1.ImageLocation = @"Doctorpic\" + lblid.Text  ;
            }
            catch (Exception)
            {

                
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {

                DAL.Doctrorpersonal doc = new DAL.Doctrorpersonal();

                DAL.Doctors doc2 = new DAL.Doctors();
                doc2.Id = Convert.ToInt16(lblid.Text);
                doc.telephone = txttele.Text;
                doc.Mobile = txtmobile.Text;
                doc.mobile2 = txtmobile2.Text;
               doc.sexidFK= (int)comboBox1.SelectedValue;
                doc.dateofbirth = dtpbirth.Value;
                doc.cvpath = txtcv.Text;
                doc.imagepath = txtpic.Text;
                doc.DoctoridFK = Convert.ToInt32(lblid.Text);
                doc.email = txtmail.Text;


                ctx.Doctrorpersonal.Add(doc);
             
                ctx.SaveChanges();
                MessageBox.Show("Data inserted  ");
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcv.Text = txtmail.Text = txtmobile.Text = txtmobile2.Text = txtpic.Text = txttele.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doctoradd3 doc = new doctoradd3();
            doc.lblid.Text = this.lblid.Text;
            
            this.Hide();
            doc.ShowDialog();
        }
    }
}
