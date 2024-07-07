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
    public partial class Image : Form
    {
        public Image()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Member open_form = new Member();
            this.Hide();
            open_form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
