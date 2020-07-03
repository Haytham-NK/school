namespace schools
{
    partial class assessments1
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
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ListViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Labelitem = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.Labelassessment = new System.Windows.Forms.Label();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(5, 112);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(100, 21);
            this.cb_item.TabIndex = 47;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(648, 342);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 46;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(567, 342);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 45;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(486, 342);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 44;
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
            this.ColumnHeader2});
            this.ListViewTeachers.HideSelection = false;
            this.ListViewTeachers.Location = new System.Drawing.Point(139, 12);
            this.ListViewTeachers.Name = "ListViewTeachers";
            this.ListViewTeachers.Size = new System.Drawing.Size(581, 324);
            this.ListViewTeachers.TabIndex = 36;
            this.ListViewTeachers.UseCompatibleStateImageBehavior = false;
            this.ListViewTeachers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "код";
            this.columnHeader4.Width = 73;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.DisplayIndex = 0;
            this.ColumnHeader.Text = "учитель";
            this.ColumnHeader.Width = 124;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.DisplayIndex = 1;
            this.ColumnHeader1.Text = "ученик";
            this.ColumnHeader1.Width = 158;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.DisplayIndex = 2;
            this.ColumnHeader2.Text = "ценка";
            this.ColumnHeader2.Width = 118;
            // 
            // Labelitem
            // 
            this.Labelitem.AutoSize = true;
            this.Labelitem.Location = new System.Drawing.Point(5, 96);
            this.Labelitem.Name = "Labelitem";
            this.Labelitem.Size = new System.Drawing.Size(52, 13);
            this.Labelitem.TabIndex = 42;
            this.Labelitem.Text = "Предмет";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(5, 28);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_surname.TabIndex = 37;
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Location = new System.Drawing.Point(5, 51);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(44, 13);
            this.LabelPatronymic.TabIndex = 43;
            this.LabelPatronymic.Text = "Ученик";
            // 
            // Labelassessment
            // 
            this.Labelassessment.AutoSize = true;
            this.Labelassessment.Location = new System.Drawing.Point(5, 12);
            this.Labelassessment.Name = "Labelassessment";
            this.Labelassessment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Labelassessment.Size = new System.Drawing.Size(45, 13);
            this.Labelassessment.TabIndex = 40;
            this.Labelassessment.Text = "Оценка";
            // 
            // cb_student
            // 
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(5, 67);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(100, 21);
            this.cb_student.TabIndex = 48;
            // 
            // assessments1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 372);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ListViewTeachers);
            this.Controls.Add(this.Labelitem);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.LabelPatronymic);
            this.Controls.Add(this.Labelassessment);
            this.Name = "assessments1";
            this.Text = "assessments1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        internal System.Windows.Forms.ListView ListViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.Label Labelitem;
        internal System.Windows.Forms.TextBox tb_surname;
        internal System.Windows.Forms.Label LabelPatronymic;
        internal System.Windows.Forms.Label Labelassessment;
        private System.Windows.Forms.ComboBox cb_student;
    }
}