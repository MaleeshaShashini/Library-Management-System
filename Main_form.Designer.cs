
namespace Library_Management_System
{
    partial class Main_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_librarian = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_aboutus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.d__4_;
            this.pictureBox1.Location = new System.Drawing.Point(65, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Library_Management_System.Properties.Resources.d__7_1;
            this.pictureBox2.Location = new System.Drawing.Point(65, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 161);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_librarian
            // 
            this.btn_librarian.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_librarian.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_librarian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_librarian.Location = new System.Drawing.Point(306, 43);
            this.btn_librarian.Name = "btn_librarian";
            this.btn_librarian.Size = new System.Drawing.Size(327, 110);
            this.btn_librarian.TabIndex = 2;
            this.btn_librarian.Text = "Librarian";
            this.btn_librarian.UseVisualStyleBackColor = false;
            this.btn_librarian.Click += new System.EventHandler(this.btn_librarian_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_member.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_member.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_member.Location = new System.Drawing.Point(306, 214);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(327, 110);
            this.btn_member.TabIndex = 3;
            this.btn_member.Text = "Member";
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_exit.Location = new System.Drawing.Point(565, 391);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 45);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_aboutus
            // 
            this.btn_aboutus.BackColor = System.Drawing.SystemColors.WindowText;
            this.btn_aboutus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aboutus.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_aboutus.Location = new System.Drawing.Point(550, 340);
            this.btn_aboutus.Name = "btn_aboutus";
            this.btn_aboutus.Size = new System.Drawing.Size(104, 45);
            this.btn_aboutus.TabIndex = 8;
            this.btn_aboutus.Text = "About us";
            this.btn_aboutus.UseVisualStyleBackColor = false;
            this.btn_aboutus.Click += new System.EventHandler(this.btn_aboutus_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.download__10_1;
            this.ClientSize = new System.Drawing.Size(688, 460);
            this.Controls.Add(this.btn_aboutus);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.btn_librarian);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_librarian;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_aboutus;
    }
}