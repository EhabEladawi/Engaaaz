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
    public partial class NewEMP : MetroFramework.Forms.MetroForm
    {
        public NewEMP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMPADD1 doc = new EMPADD1();
            doc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMPsearch1 emp = new EMPsearch1();
            emp.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMPsearch2 emp = new EMPsearch2();
            emp.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMPsearch3 emp = new EMPsearch3();
            emp.ShowDialog();
        }
    }
}