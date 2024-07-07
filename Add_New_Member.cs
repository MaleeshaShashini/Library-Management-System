using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Library_Management_System
{
    public partial class Add_New_Member : Form
    {
        public Add_New_Member()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Librarian open_form = new Librarian();
            this.Hide();
            open_form.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_idno.Clear();
            txt_fullname.Clear();
            txt_namewithinitials.Clear();
            txt_age.Clear();
            txt_dateofbirth.ResetText();
            com_gender.ResetText();
            txt_nicno.Clear();
            txt_email.Clear();
            txt_contactno.Clear();
            txt_address.Clear();


        }
    }
}
