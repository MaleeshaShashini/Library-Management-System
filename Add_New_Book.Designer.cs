
namespace Library_Management_System
{
    partial class Add_New_Book
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_book = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_book = new System.Windows.Forms.Label();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.com_category = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.com_language = new System.Windows.Forms.ComboBox();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.txt_pubdate = new System.Windows.Forms.TextBox();
            this.txt_pages = new System.Windows.Forms.TextBox();
            this.lbl_pubdate = new System.Windows.Forms.Label();
            this.lbl_pages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(689, 401);
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
            this.btn_back.Location = new System.Drawing.Point(572, 401);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 37);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_clear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clear.Location = new System.Drawing.Point(616, 315);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 46);
            this.btn_clear.TabIndex = 33;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_view.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_view.Location = new System.Drawing.Point(616, 247);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(107, 46);
            this.btn_view.TabIndex = 32;
            this.btn_view.Text = "VIEW";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_delete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(616, 179);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 46);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_update.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(616, 111);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 46);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_insert.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_insert.Location = new System.Drawing.Point(616, 40);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(107, 46);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_author.Location = new System.Drawing.Point(213, 129);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(363, 20);
            this.txt_author.TabIndex = 41;
            // 
            // txt_book
            // 
            this.txt_book.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_book.Location = new System.Drawing.Point(213, 93);
            this.txt_book.Name = "txt_book";
            this.txt_book.Size = new System.Drawing.Size(363, 20);
            this.txt_book.TabIndex = 40;
            // 
            // txt_isbn
            // 
            this.txt_isbn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_isbn.Location = new System.Drawing.Point(213, 58);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(363, 20);
            this.txt_isbn.TabIndex = 39;
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_language.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_language.Location = new System.Drawing.Point(29, 164);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(94, 16);
            this.lbl_language.TabIndex = 37;
            this.lbl_language.Text = "LANGUAGE :";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_author.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_author.Location = new System.Drawing.Point(29, 129);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(76, 16);
            this.lbl_author.TabIndex = 36;
            this.lbl_author.Text = "AUTHOR :";
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_book.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_book.Location = new System.Drawing.Point(29, 93);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(59, 16);
            this.lbl_book.TabIndex = 35;
            this.lbl_book.Text = "BOOK :";
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_isbn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isbn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_isbn.Location = new System.Drawing.Point(29, 59);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(53, 16);
            this.lbl_isbn.TabIndex = 34;
            this.lbl_isbn.Text = "ISBN :";
            // 
            // com_category
            // 
            this.com_category.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.com_category.FormattingEnabled = true;
            this.com_category.Items.AddRange(new object[] {
            "Action and adventure",
            "Autobiography",
            "Biography",
            "Business/economics",
            "Children\'s",
            "Crafts/hobbies",
            "Classic",
            "Cookbook",
            "Comic book",
            "Diary",
            "Dictionary",
            "Crime",
            "Encyclopedia",
            "Fairytale",
            "Health/fitness",
            "Fantasy",
            "Historical fiction",
            "Horror",
            "Science fiction",
            "Short story",
            "Science",
            ""});
            this.com_category.Location = new System.Drawing.Point(213, 201);
            this.com_category.Name = "com_category";
            this.com_category.Size = new System.Drawing.Size(121, 21);
            this.com_category.TabIndex = 45;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_category.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_category.Location = new System.Drawing.Point(30, 202);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(93, 16);
            this.lbl_category.TabIndex = 44;
            this.lbl_category.Text = "CATEGORY :";
            // 
            // com_language
            // 
            this.com_language.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.com_language.FormattingEnabled = true;
            this.com_language.Items.AddRange(new object[] {
            "Sinhala",
            "English",
            "Tamil"});
            this.com_language.Location = new System.Drawing.Point(213, 163);
            this.com_language.Name = "com_language";
            this.com_language.Size = new System.Drawing.Size(121, 21);
            this.com_language.TabIndex = 46;
            // 
            // txt_publisher
            // 
            this.txt_publisher.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_publisher.Location = new System.Drawing.Point(213, 240);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(363, 20);
            this.txt_publisher.TabIndex = 48;
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_publisher.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publisher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_publisher.Location = new System.Drawing.Point(29, 241);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(98, 16);
            this.lbl_publisher.TabIndex = 47;
            this.lbl_publisher.Text = "PUBLISHER :";
            // 
            // txt_pubdate
            // 
            this.txt_pubdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_pubdate.Location = new System.Drawing.Point(213, 315);
            this.txt_pubdate.Name = "txt_pubdate";
            this.txt_pubdate.Size = new System.Drawing.Size(363, 20);
            this.txt_pubdate.TabIndex = 52;
            // 
            // txt_pages
            // 
            this.txt_pages.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_pages.Location = new System.Drawing.Point(213, 280);
            this.txt_pages.Name = "txt_pages";
            this.txt_pages.Size = new System.Drawing.Size(363, 20);
            this.txt_pages.TabIndex = 51;
            // 
            // lbl_pubdate
            // 
            this.lbl_pubdate.AutoSize = true;
            this.lbl_pubdate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_pubdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pubdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pubdate.Location = new System.Drawing.Point(29, 315);
            this.lbl_pubdate.Name = "lbl_pubdate";
            this.lbl_pubdate.Size = new System.Drawing.Size(83, 16);
            this.lbl_pubdate.TabIndex = 50;
            this.lbl_pubdate.Text = " PUBDATE:";
            // 
            // lbl_pages
            // 
            this.lbl_pages.AutoSize = true;
            this.lbl_pages.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_pages.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_pages.Location = new System.Drawing.Point(29, 281);
            this.lbl_pages.Name = "lbl_pages";
            this.lbl_pages.Size = new System.Drawing.Size(65, 16);
            this.lbl_pages.TabIndex = 49;
            this.lbl_pages.Text = "PAGES :";
            // 
            // Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.images__34_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pubdate);
            this.Controls.Add(this.txt_pages);
            this.Controls.Add(this.lbl_pubdate);
            this.Controls.Add(this.lbl_pages);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.lbl_publisher);
            this.Controls.Add(this.com_language);
            this.Controls.Add(this.com_category);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_book);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_book);
            this.Controls.Add(this.lbl_isbn);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Name = "Add_New_Book";
            this.Text = "Add_New_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_book;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.ComboBox com_category;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox com_language;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.TextBox txt_pubdate;
        private System.Windows.Forms.TextBox txt_pages;
        private System.Windows.Forms.Label lbl_pubdate;
        private System.Windows.Forms.Label lbl_pages;
    }
}