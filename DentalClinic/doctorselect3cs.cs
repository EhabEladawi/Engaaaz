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
    public partial class doctorselect3cs : MetroFramework.Forms.MetroForm
    {
        int id = 0;
        public doctorselect3cs()
        {
            InitializeComponent();
        }

        private void doctorselect3cs_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.dataGridView1.DataSource = ctx.Doctors.Select(doc => new { ID = doc.Id, Username = doc.name }).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.dataGridView1.DataSource = ctx.Doctors.Where(doc => doc.name.Contains(textBox1.Text)).ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (DAL.MyContext ctx = new DAL.MyContext())
                    {
                        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        List<DAL.Doctors> doc1 = ctx.Doctors.Where(docs => docs.Id == id).ToList();
                        List<DAL.Doctrorpersonal> doc2 = ctx.Doctrorpersonal.Where(docss => docss.DoctoridFK == id).ToList();
                        List<DAL.doctorscientific> doc3 = ctx.doctorscientific.Where(docsss => docsss.doctoridFK == id).ToList();
                        List<DAL.Doctorclinicinformation> doc4 = ctx.Doctorclinicinformation.Where(docssss => docssss.doctoridFK == id).ToList();
                        try
                        {
                            DAL.Doctors doctors = doc1[0];
                            ctx.Doctors.Remove(doctors);
                            ctx.SaveChanges();
                            MessageBox.Show("Doctor Deleted");
                        }
                        catch (Exception)
                        {

                            
                        }
                        
                        
                        DAL.Doctrorpersonal docotrspersonal = doc2[0];
                        ctx.Doctrorpersonal.Remove(docotrspersonal);

                        DAL.doctorscientific doctorscientific = null;

                        int i = 0;
                        foreach (var item in doc3)
                        {
                            doctorscientific = doc3[i];
                            ctx.doctorscientific.Remove(doctorscientific);
                            i++;
                        }

                        DAL.Doctorclinicinformation Doctorclinicinformation = doc4[0];
                        ctx.Doctorclinicinformation.Remove(Doctorclinicinformation);
                        MessageBox.Show("Data ALL Deleted ... ");
                        ctx.SaveChanges();
                        
                    }

                }
                catch (Exception)
                {

                    
                }

                using (DAL.MyContext ctxxx = new DAL.MyContext())
                {
                    this.dataGridView1.DataSource = ctxxx.Doctors.Select(doc => new { ID = doc.Id, Username = doc.name }).ToList();
                }

            }
            else
            {
                // If 'No', do something here.
            }
        }
    }
}
