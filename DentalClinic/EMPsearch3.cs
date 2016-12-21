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
    public partial class EMPsearch3 : MetroFramework.Forms.MetroForm
    {
        int id=0;
        public EMPsearch3()
        {
            InitializeComponent();
        }

        private void EMPsearch3_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.dataGridView1.DataSource = ctx.EMP.Select(doc => new { ID = doc.Id, Username = doc.name }).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.dataGridView1.DataSource = ctx.EMP.Where(doc => doc.name.Contains(textBox1.Text)).ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
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
                        List<DAL.EMP> doc1 = ctx.EMP.Where(emp => emp.Id == id).ToList();
                        List<DAL.EMPClinic> doc2 = ctx.EMPClinic.Where(emps => emps.EMPIDFK == id).ToList();
                        List<DAL.EmpPersonal> doc3 = ctx.EmpPersonal.Where(empss => empss.EMPIDFK == id).ToList();
                        try
                        {
                            DAL.EMP empo = doc1[0];
                            ctx.EMP.Remove(empo);
                            ctx.SaveChanges();
                            MessageBox.Show("Deleted");
                        }
                        catch (Exception)
                        {
                            

                        }


                        DAL.EMPClinic EMPClinic = doc2[0];
                        ctx.EMPClinic.Remove(EMPClinic);

                        

                        DAL.EmpPersonal EmpPersonal = doc3[0];
                        ctx.EmpPersonal.Remove(EmpPersonal);
                        MessageBox.Show("Deleted ... ");
                        ctx.SaveChanges();

                    }

                }
                catch (Exception)
                {


                }

                using (DAL.MyContext ctxxx = new DAL.MyContext())
                {
                    this.dataGridView1.DataSource = ctxxx.EMP.Select(EMP => new { ID = EMP.Id, Username = EMP.name }).ToList();
                }

            }
            else
            {
                // If 'No', do something here.
            }
        }
    }
    
}
