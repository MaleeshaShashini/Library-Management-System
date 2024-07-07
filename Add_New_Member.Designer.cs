
namespace Library_Management_System
{
    partial class Add_New_Member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_idno = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_namewithinitials = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_dateofbirth = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_nicno = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_contactno = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_idno = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_namewithinitials = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_nicno = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contactno = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.com_gender = new System.Windows.Forms.ComboBox();
            this.txt_dateofbirth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(695, 392);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 37);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(578, 392);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 37);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_idno
            // 
            this.lbl_idno.AutoSize = true;
            this.lbl_idno.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_idno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_idno.Location = new System.Drawing.Point(39, 51);
            this.lbl_idno.Name = "lbl_idno";
            this.lbl_idno.Size = new System.Drawing.Size(61, 16);
            this.lbl_idno.TabIndex = 6;
            this.lbl_idno.Text = "ID NO :";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_fullname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fullname.Location = new System.Drawing.Point(39, 83);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(97, 16);
            this.lbl_fullname.TabIndex = 7;
            this.lbl_fullname.Text = "FULL NAME :";
            // 
            // lbl_namewithinitials
            // 
            this.lbl_namewithinitials.AutoSize = true;
            this.lbl_namewithinitials.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_namewithinitials.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namewithinitials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_namewithinitials.Location = new System.Drawing.Point(39, 113);
            this.lbl_namewithinitials.Name = "lbl_namewithinitials";
            this.lbl_namewithinitials.Size = new System.Drawing.Size(168, 16);
            this.lbl_namewithinitials.TabIndex = 8;
            this.lbl_namewithinitials.Text = "NAME WITH INITIALS :";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_age.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_age.Location = new System.Drawing.Point(39, 148);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(47, 16);
            this.lbl_age.TabIndex = 9;
            this.lbl_age.Text = "AGE :";
            // 
            // lbl_dateofbirth
            // 
            this.lbl_dateofbirth.AutoSize = true;
            this.lbl_dateofbirth.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_dateofbirth.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateofbirth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_dateofbirth.Location = new System.Drawing.Point(39, 181);
            this.lbl_dateofbirth.Name = "lbl_dateofbirth";
            this.lbl_dateofbirth.Size = new System.Drawing.Size(126, 16);
            this.lbl_dateofbirth.TabIndex = 10;
            this.lbl_dateofbirth.Text = "DATE OF BIRTH :";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_gender.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_gender.Location = new System.Drawing.Point(39, 212);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(76, 16);
            this.lbl_gender.TabIndex = 11;
            this.lbl_gender.Text = "GENDER :";
            // 
            // lbl_nicno
            // 
            this.lbl_nicno.AutoSize = true;
            this.lbl_nicno.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_nicno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nicno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nicno.Location = new System.Drawing.Point(39, 244);
            this.lbl_nicno.Name = "lbl_nicno";
            this.lbl_nicno.Size = new System.Drawing.Size(71, 16);
            this.lbl_nicno.TabIndex = 12;
            this.lbl_nicno.Text = "NIC NO :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_email.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(39, 278);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 16);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "EMAIL :";
            // 
            // lbl_contactno
            // 
            this.lbl_contactno.AutoSize = true;
            this.lbl_contactno.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_contactno.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_contactno.Location = new System.Drawing.Point(39, 312);
            this.lbl_contactno.Name = "lbl_contactno";
            this.lbl_contactno.Size = new System.Drawing.Size(111, 16);
            this.lbl_contactno.TabIndex = 14;
            this.lbl_contactno.Text = "CONTACT NO :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_address.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_address.Location = new System.Drawing.Point(39, 346);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(84, 16);
            this.lbl_address.TabIndex = 15;
            this.lbl_address.Text = "ADDRESS :";
            // 
            // txt_idno
            // 
            this.txt_idno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_idno.Location = new System.Drawing.Point(213, 50);
            this.txt_idno.Name = "txt_idno";
            this.txt_idno.Size = new System.Drawing.Size(370, 20);
            this.txt_idno.TabIndex = 16;
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_fullname.Location = new System.Drawing.Point(213, 82);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(370, 20);
            this.txt_fullname.TabIndex = 17;
            // 
            // txt_namewithinitials
            // 
            this.txt_namewithinitials.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_namewithinitials.Location = new System.Drawing.Point(213, 112);
            this.txt_namewithinitials.Name = "txt_namewithinitials";
            this.txt_namewithinitials.Size = new System.Drawing.Size(370, 20);
            this.txt_namewithinitials.TabIndex = 18;
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_age.Location = new System.Drawing.Point(213, 147);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(370, 20);
            this.txt_age.TabIndex = 19;
            // 
            // txt_nicno
            // 
            this.txt_nicno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_nicno.Location = new System.Drawing.Point(213, 243);
            this.txt_nicno.Name = "txt_nicno";
            this.txt_nicno.Size = new System.Drawing.Size(370, 20);
            this.txt_nicno.TabIndex = 20;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_email.Location = new System.Drawing.Point(213, 277);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(370, 20);
            this.txt_email.TabIndex = 21;
            // 
            // txt_contactno
            // 
            this.txt_contactno.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_contactno.Location = new System.Drawing.Point(213, 311);
            this.txt_contactno.Name = "txt_contactno";
            this.txt_contactno.Size = new System.Drawing.Size(370, 20);
            this.txt_contactno.TabIndex = 22;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_address.Location = new System.Drawing.Point(213, 345);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(370, 20);
            this.txt_address.TabIndex = 23;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_insert.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_insert.Location = new System.Drawing.Point(631, 27);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(107, 46);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_update.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(631, 98);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 46);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_delete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(631, 166);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 46);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_view.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_view.Location = new System.Drawing.Point(631, 234);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(107, 46);
            this.btn_view.TabIndex = 27;
            this.btn_view.Text = "VIEW";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_clear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clear.Location = new System.Drawing.Point(631, 302);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 46);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // com_gender
            // 
            this.com_gender.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.com_gender.FormattingEnabled = true;
            this.com_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.com_gender.Location = new System.Drawing.Point(213, 212);
            this.com_gender.Name = "com_gender";
            this.com_gender.Size = new System.Drawing.Size(121, 21);
            this.com_gender.TabIndex = 30;
            // 
            // txt_dateofbirth
            // 
            this.txt_dateofbirth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_dateofbirth.Location = new System.Drawing.Point(213, 181);
            this.txt_dateofbirth.Name = "txt_dateofbirth";
            this.txt_dateofbirth.Size = new System.Drawing.Size(370, 20);
            this.txt_dateofbirth.TabIndex = 31;
            // 
            // Add_New_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.images__34_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_dateofbirth);
            this.Controls.Add(this.com_gender);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_contactno);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nicno);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_namewithinitials);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.txt_idno);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_contactno);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nicno);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_dateofbirth);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_namewithinitials);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_idno);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Name = "Add_New_Member";
            this.Text = "Add_New_Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_idno;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_namewithinitials;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_dateofbirth;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_nicno;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contactno;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_idno;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_namewithinitials;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_nicno;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contactno;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox com_gender;
        private System.Windows.Forms.TextBox txt_dateofbirth;
    }
}