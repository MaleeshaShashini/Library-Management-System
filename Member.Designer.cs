
namespace Library_Management_System
{
    partial class Member
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(596, 383);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(713, 383);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 33);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Image = global::Library_Management_System.Properties.Resources.download__1_1;
            this.btn_about.Location = new System.Drawing.Point(28, 68);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(160, 250);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = " ABOUT";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_borrow.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrow.Image = global::Library_Management_System.Properties.Resources.download__5_;
            this.btn_borrow.Location = new System.Drawing.Point(220, 68);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(160, 250);
            this.btn_borrow.TabIndex = 4;
            this.btn_borrow.Text = "BORROW";
            this.btn_borrow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_borrow.UseVisualStyleBackColor = false;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Image = global::Library_Management_System.Properties.Resources.images__29_;
            this.btn_return.Location = new System.Drawing.Point(413, 68);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(160, 250);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "RETURN";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_image.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_image.Image = global::Library_Management_System.Properties.Resources.rrrrrrrrrrrrrrrrrrrrrrr;
            this.btn_image.Location = new System.Drawing.Point(606, 68);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(166, 250);
            this.btn_image.TabIndex = 6;
            this.btn_image.Text = "IMAGES";
            this.btn_image.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_images_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.a__11_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Name = "Member";
            this.Text = "Member";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_image;
    }
}