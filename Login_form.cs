using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string un = txt_username.Text;
            string pw = txt_password.Text;
            if (un == "Maleesha" && pw == "123456")
            {
                Main_form open_form = new Main_form();
                this.Hide();
                open_form.Show();
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Login Fail!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
