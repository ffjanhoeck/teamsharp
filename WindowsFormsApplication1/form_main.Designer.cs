namespace WindowsFormsApplication1
{
    partial class form_main
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
            this.listView_homework = new System.Windows.Forms.ListView();
            this.columnHeader_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_expire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_homework = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button_sortByExpireDate = new System.Windows.Forms.Button();
            this.checkBox_showAll = new System.Windows.Forms.CheckBox();
            this.columnHeader_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_homework
            // 
            this.listView_homework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_homework.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_title,
            this.columnHeader_owner,
            this.columnHeader_subject,
            this.columnHeader_expire});
            this.listView_homework.FullRowSelect = true;
            this.listView_homework.Location = new System.Drawing.Point(12, 12);
            this.listView_homework.Name = "listView_homework";
            this.listView_homework.Size = new System.Drawing.Size(263, 282);
            this.listView_homework.TabIndex = 0;
            this.listView_homework.UseCompatibleStateImageBehavior = false;
            this.listView_homework.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_title
            // 
            this.columnHeader_title.Text = "Title";
            this.columnHeader_title.Width = 90;
            // 
            // columnHeader_owner
            // 
            this.columnHeader_owner.Text = "Ersteller";
            this.columnHeader_owner.Width = 68;
            // 
            // columnHeader_expire
            // 
            this.columnHeader_expire.DisplayIndex = 2;
            this.columnHeader_expire.Text = "Ablaufdatum";
            this.columnHeader_expire.Width = 101;
            // 
            // textBox_homework
            // 
            this.textBox_homework.Location = new System.Drawing.Point(0, 0);
            this.textBox_homework.Name = "textBox_homework";
            this.textBox_homework.Size = new System.Drawing.Size(100, 20);
            this.textBox_homework.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.Location = new System.Drawing.Point(12, 352);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(263, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Hinzufügen";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(281, 352);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(173, 23);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Änderungen übernehmen";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Location = new System.Drawing.Point(547, 352);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Löschen";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(281, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 336);
            this.tabControl1.TabIndex = 5;
            // 
            // button_sortByExpireDate
            // 
            this.button_sortByExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sortByExpireDate.Location = new System.Drawing.Point(12, 323);
            this.button_sortByExpireDate.Name = "button_sortByExpireDate";
            this.button_sortByExpireDate.Size = new System.Drawing.Size(263, 23);
            this.button_sortByExpireDate.TabIndex = 6;
            this.button_sortByExpireDate.Text = "Sortiere nach Ablaufdatum";
            this.button_sortByExpireDate.UseVisualStyleBackColor = true;
            this.button_sortByExpireDate.Click += new System.EventHandler(this.button_sortByExpireDate_Click);
            // 
            // checkBox_showAll
            // 
            this.checkBox_showAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_showAll.AutoSize = true;
            this.checkBox_showAll.Location = new System.Drawing.Point(97, 300);
            this.checkBox_showAll.Name = "checkBox_showAll";
            this.checkBox_showAll.Size = new System.Drawing.Size(89, 17);
            this.checkBox_showAll.TabIndex = 7;
            this.checkBox_showAll.Text = "Alle anzeigen";
            this.checkBox_showAll.UseVisualStyleBackColor = true;
            this.checkBox_showAll.CheckedChanged += new System.EventHandler(this.checkBox_showAll_CheckedChanged);
            // 
            // columnHeader_subject
            // 
            this.columnHeader_subject.DisplayIndex = 3;
            this.columnHeader_subject.Text = "Fach";
            // 
            // button_done
            // 
            this.button_done.Location = new System.Drawing.Point(460, 352);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(81, 23);
            this.button_done.TabIndex = 8;
            this.button_done.Text = "Erledigt";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 387);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.checkBox_showAll);
            this.Controls.Add(this.button_sortByExpireDate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listView_homework);
            this.Name = "form_main";
            this.ShowIcon = false;
            this.Text = "Hausaufgaben-Manager Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_homework;
        private System.Windows.Forms.TextBox textBox_homework;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader columnHeader_title;
        private System.Windows.Forms.ColumnHeader columnHeader_owner;
        private System.Windows.Forms.ColumnHeader columnHeader_expire;
        private System.Windows.Forms.Button button_sortByExpireDate;
        private System.Windows.Forms.CheckBox checkBox_showAll;
        private System.Windows.Forms.ColumnHeader columnHeader_subject;
        private System.Windows.Forms.Button button_done;
    }
}