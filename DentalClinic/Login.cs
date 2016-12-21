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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        EntryPointNotFoundException ef = new EntryPointNotFoundException();
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtusername.Text != string.Empty)
            {
                if (txtpass.Text != string.Empty)
                {
                    using (DAL.MyContext cn = new DAL.MyContext())
                    {
                        //try
                        //{
                            foreach (var EM in cn.EMP)
                            {
                                if (txtusername.Text == EM.name && txtpass.Text == EM.password.ToString())
                                {
                                    Main main = new Main();
                                    this.Hide();
                                    main.ShowDialog();
                                }
                            }

                            foreach (var Doc in cn.Doctors)
                            {
                                if (txtusername.Text == Doc.name && txtpass.Text == Doc.password.ToString())
                                {
                                    Main main = new Main();
                                    this.Hide();
                                    main.ShowDialog();
                                }
                            }
                        //}
                        //catch (Exception)
                        //{

                        //    MessageBox.Show("invaled username or password ");;
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("please enter password");

                }
            }
            else
            {
                MessageBox.Show("please enter username");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpass.Text = txtusername.Text="";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
