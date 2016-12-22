using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic.adminprocess
{
    public partial class historyadmin : MetroFramework.Forms.MetroForm
    {
        public historyadmin()
        {
            InitializeComponent();
        }

        private void historyadmin_Load(object sender, EventArgs e)
        {
            using (DAL.MyContext ctx = new DAL.MyContext())
            {
                this.radCheckedListBox1.DataSource = ctx.medicalhistory.Select(doc => new { id = doc.Id, name = doc.Name }).ToList();
                radCheckedListBox1.DisplayMember = "Name";
                radCheckedListBox1.ValueMember = "Id";
            }
        }

        private void radCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = radCheckedListBox1.SelectedItem.Text;

            }
            catch (Exception)
            {


            }




        }

        private void radCheckedListBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = radCheckedListBox1.SelectedItem.Text;

            }
            catch (Exception)
            {


            }
        }

        private void radCheckedListBox1_SelectedItemsChanged(object sender, EventArgs e)
        {




        }

        private void radCheckedListBox1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = radCheckedListBox1.SelectedItem.Text;

            }
            catch (Exception)
            {

                
            }
        }
    }
}
