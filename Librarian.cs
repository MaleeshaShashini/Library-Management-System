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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_form open_form = new Main_form();
            this.Hide();
            open_form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addnewmember_Click(object sender, EventArgs e)
        {
            Add_New_Member open_form = new Add_New_Member();
            this.Hide();
            open_form.Show();
        }

        private void btn_addnewbook_Click(object sender, EventArgs e)
        {
            Add_New_Book open_form = new Add_New_Book();
            this.Hide();
            open_form.Show();
        }
    }
}
