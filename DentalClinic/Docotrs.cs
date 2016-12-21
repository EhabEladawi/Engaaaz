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
    public partial class Docotrs : MetroFramework.Forms.MetroForm
    {
        public Docotrs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctoradd1 doc = new Doctoradd1();
            doc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctorselect doc = new Doctorselect();
            doc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Docselect2 doc = new Docselect2();
            doc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctorselect3cs doc = new doctorselect3cs();
            doc.ShowDialog();
        }
    }
}
