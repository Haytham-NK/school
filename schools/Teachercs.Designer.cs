namespace schools
{
    partial class Theachercs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theachercs));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ListViewTeachers = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Labelitem = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "код";
            this.columnHeader4.Width = 73;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(659, 342);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 33;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(578, 342);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 32;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(497, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Создать";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ListViewTeachers
            // 
            this.ListViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.ColumnHeader,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader5});
            this.ListViewTeachers.HideSelection = false;
            this.ListViewTeachers.Location = new System.Drawing.Point(150, 12);
            this.ListViewTeachers.Name = "ListViewTeachers";
            this.ListViewTeachers.Size = new System.Drawing.Size(581, 324);
            this.ListViewTeachers.TabIndex = 22;
            this.ListViewTeachers.UseCompatibleStateImageBehavior = false;
            this.ListViewTeachers.View = System.Windows.Forms.View.Details;
            this.ListViewTeachers.SelectedIndexChanged += new System.EventHandler(this.ListViewStudents_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DisplayIndex = 0;
            this.ColumnHeader.Text = "Имя";
            this.ColumnHeader.Width = 124;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.DisplayIndex = 1;
            this.ColumnHeader1.Text = "Фамилия";
            this.ColumnHeader1.Width = 158;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.DisplayIndex = 2;
            this.ColumnHeader2.Text = "Отчество";
            this.ColumnHeader2.Width = 118;
            // 
            // Labelitem
            // 
            this.Labelitem.AutoSize = true;
            this.Labelitem.Location = new System.Drawing.Point(16, 129);
            this.Labelitem.Name = "Labelitem";
            this.Labelitem.Size = new System.Drawing.Size(52, 13);
            this.Labelitem.TabIndex = 29;
            this.Labelitem.Text = "Предмет";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(16, 51);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 28;
            this.LabelName.Text = "Имя";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 26;
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.Location = new System.Drawing.Point(16, 106);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(100, 20);
            this.tb_patronymic.TabIndex = 24;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(16, 28);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 23;
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Location = new System.Drawing.Point(13, 90);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.LabelPatronymic.TabIndex = 30;
            this.LabelPatronymic.Text = "Отчество";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(16, 12);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(56, 13);
            this.LabelSurname.TabIndex = 27;
            this.LabelSurname.Text = "Фамилия";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(16, 145);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(100, 21);
            this.cb_item.TabIndex = 35;
            this.cb_item.SelectedIndexChanged += new System.EventHandler(this.cb_item_SelectedIndexChanged);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "предмет";
            this.ColumnHeader5.Width = 103;
            // 
            // Theachercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 374);
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ListViewTeachers);
            this.Controls.Add(this.Labelitem);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.LabelPatronymic);
            this.Controls.Add(this.LabelSurname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Theachercs";
            this.Text = " Учителя";
            this.Load += new System.EventHandler(this.Учителя_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.ListView ListViewTeachers;
        internal System.Windows.Forms.ColumnHeader ColumnHeader;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.Label Labelitem;
        internal System.Windows.Forms.Label LabelName;
        internal System.Windows.Forms.TextBox tb_name;
        internal System.Windows.Forms.TextBox tb_patronymic;
        internal System.Windows.Forms.TextBox tb_surname;
        internal System.Windows.Forms.Label LabelPatronymic;
        internal System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
    }
}