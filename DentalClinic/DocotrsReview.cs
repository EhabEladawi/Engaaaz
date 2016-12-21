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
   
    public partial class DocotrsReview : MetroFramework.Forms.MetroForm
    {
        int id = 0;

        public DocotrsReview()
        {
            InitializeComponent();
        }

        public string sex(int id)
        {
            if (id == 1)
                return "Male";
            else
                return "Female";

        }
        private void DocotrsReview_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(lblid.Text);
            using (DAL.MyContext ctxx = new DAL.MyContext())
            {
                dataGridView1.DataSource = ctxx.Doctrorpersonal.Where(doc => doc.DoctoridFK == id).ToList();
                try
                {
                    lbltele.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    lblmobile1.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    lblmobile2.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    lblmail.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    pictureBox1.ImageLocation = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    lblcv.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    lbldateofbirth.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
                    lblgender.Text = sex(Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString())).ToString();

                }
                catch (Exception)
                {


                }
                using (DAL.MyContext ctx = new DAL.MyContext())
                {
                    dataGridView3.DataSource = ctx.doctorscientific.Where(doc => doc.doctoridFK == id).ToList();
                    try
                    {
                        lblgree.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
                        lbldgree.Text = dataGridView3.Rows[0].Cells[2].Value.ToString();
                        lblworkpalce.Text = dataGridView3.Rows[0].Cells[4].Value.ToString();

                        foreach (DataGridViewRow row in dataGridView3.Rows)
                        {
                            if (lblspecia.Text == "None")
                            {
                                lblspecia.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();
                            }
                            else
                            {
                                lblspecia.Text += " , " + dataGridView3.Rows[0].Cells[3].Value.ToString();
                            }


                        }
                    }
                    catch (Exception)
                    {


                    }

                }
                id = Convert.ToInt32(lblid.Text);

                using (DAL.MyContext ctx = new DAL.MyContext())
                {
                    dataGridView2.DataSource = ctx.Doctorclinicinformation.Where(doc => doc.doctoridFK == id).ToList();
                    try
                    {
                        txtdateofhire.Text = (dataGridView2.Rows[0].Cells[3].Value.ToString());
                        txtpre.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();

                    }
                    catch (Exception)
                    {


                    }
                }


            }

            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                dataGridView4.DataSource = ctx.Doctors.Where(doc => doc.Id == id).ToList();
                try
                {
                    lblname.Text= (dataGridView4.Rows[0].Cells[1].Value.ToString());
                }
                catch (Exception)
                {


                }
            }


        }
    

        private void lblcv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.lblcv.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start(lblcv.Text);
        }
    }
}
