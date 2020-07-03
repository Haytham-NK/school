namespace schools
{
    partial class Students
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.ListViewStudents = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_class = new System.Windows.Forms.TextBox();
            this.tb_patronymic = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewStudents
            // 
            this.ListViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.ColumnHeader,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.ListViewStudents.HideSelection = false;
            this.ListViewStudents.Location = new System.Drawing.Point(139, 12);
            this.ListViewStudents.Name = "ListViewStudents";
            this.ListViewStudents.Size = new System.Drawing.Size(581, 324);
            this.ListViewStudents.TabIndex = 9;
            this.ListViewStudents.UseCompatibleStateImageBehavior = false;
            this.ListViewStudents.View = System.Windows.Forms.View.Details;
            this.ListViewStudents.SelectedIndexChanged += new System.EventHandler(this.ListViewStudents_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DisplayIndex = 0;
            this.ColumnHeader.Text = "Имя";
            this.ColumnHeader.Width = 121;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.DisplayIndex = 1;
            this.ColumnHeader1.Text = "Фамилия";
            this.ColumnHeader1.Width = 127;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.DisplayIndex = 2;
            this.ColumnHeader2.Text = "Отчество";
            this.ColumnHeader2.Width = 170;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.DisplayIndex = 3;
            this.ColumnHeader3.Text = "Класс";
            this.ColumnHeader3.Width = 99;
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Location = new System.Drawing.Point(2, 90);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.LabelPatronymic.TabIndex = 17;
            this.LabelPatronymic.Text = "Отчество";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Location = new System.Drawing.Point(5, 129);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(38, 13);
            this.LabelClass.TabIndex = 16;
            this.LabelClass.Text = "Класс";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(5, 51);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(29, 13);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Имя";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(5, 12);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(56, 13);
            this.LabelSurname.TabIndex = 14;
            this.LabelSurname.Text = "Фамилия";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(5, 67);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 13;
            // 
            // tb_class
            // 
            this.tb_class.Location = new System.Drawing.Point(5, 145);
            this.tb_class.Name = "tb_class";
            this.tb_class.Size = new System.Drawing.Size(100, 20);
            this.tb_class.TabIndex = 12;
            // 
            // tb_patronymic
            // 
            this.tb_patronymic.Location = new System.Drawing.Point(5, 106);
            this.tb_patronymic.Name = "tb_patronymic";
            this.tb_patronymic.Size = new System.Drawing.Size(100, 20);
            this.tb_patronymic.TabIndex = 11;
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(5, 28);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 10;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(648, 342);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 20;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(567, 342);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 19;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(486, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Создать";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "код";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 371);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ListViewStudents);
            this.Controls.Add(this.LabelPatronymic);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelSurname);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_class);
            this.Controls.Add(this.tb_patronymic);
            this.Controls.Add(this.tb_surname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.Text = "Студенты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView ListViewStudents;
        internal System.Windows.Forms.ColumnHeader ColumnHeader;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Label LabelPatronymic;
        internal System.Windows.Forms.Label LabelClass;
        internal System.Windows.Forms.Label LabelName;
        internal System.Windows.Forms.Label LabelSurname;
        internal System.Windows.Forms.TextBox tb_name;
        internal System.Windows.Forms.TextBox tb_class;
        internal System.Windows.Forms.TextBox tb_patronymic;
        internal System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

