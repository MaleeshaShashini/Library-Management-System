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
    public partial class Member : Form
    {
        public Member()
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

        private void btn_books_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            About open_form = new About();
            this.Hide();
            open_form.Show();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            Borrow open_form = new Borrow();
            this.Hide();
            open_form.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Return open_form = new Return();
            this.Hide();
            open_form.Show();
        }

        private void btn_images_Click(object sender, EventArgs e)
        {
            Image open_form = new Image();
            this.Hide();
            open_form.Show();
        }
    }
}
