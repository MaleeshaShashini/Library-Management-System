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
    public partial class About_us : Form
    {
        public About_us()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_form open_form= new Main_form();
            this.Hide();
            open_form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
