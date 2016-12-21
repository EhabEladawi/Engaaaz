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
    public partial class Docselect2 : MetroFramework.Forms.MetroForm
    {
        public string id;
        public Docselect2()
        {
            InitializeComponent();
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

        private void Docselect2_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.dataGridView1.DataSource = ctx.Doctors.Select(doc => new { ID = doc.Id, Username = doc.name }).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Docmanage1 doc = new Docmanage1();
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            doc.lblid.Text = id.ToString(); ;
            doc.ShowDialog();
            this.Hide();
        }
    }
}
