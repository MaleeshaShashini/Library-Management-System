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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_librarian_Click(object sender, EventArgs e)
        {
            Librarian open_form = new Librarian();
            this.Hide();
            open_form.Show();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            Member open_form = new Member();
            this.Hide();
            open_form.Show();
        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
             About_us  open_form = new About_us ();
            this.Hide();
            open_form.Show();
        }
    }
}
