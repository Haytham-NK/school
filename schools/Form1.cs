using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schools
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void ListViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count == 1)
            {
                Students student = ListViewStudents.SelectedItems[0].Tag as Students;
                student.Surname = tb_surname.Text;
                student.Name = tb_name.Text;
                student.patronymic = tb_patronymic.Text;
                student.Class = tb_class.Text;
            }
            else
            {
                tb_surname.Text = "";
                tb_name.Text = "";
                tb_patronymic.Text = "";
                tb_class.Text = "";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.Surname = tb_surname.Text;
            student.Name = tb_name.Text;
            student.patronymic = tb_patronymic.Text;
            student.Class = tb_class.Text;
            Program.school.Students.Add(student);
            Program.school.SaveChanges();
            ShowForm1();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewStudents.SelectedItems.Count == 1)
                {
                    Students student = ListViewStudents.SelectedItems[0].Tag as Students;
                    Program.school.Students.Remove(student);
                    Program.school.SaveChanges();
                }
                tb_surname.Text = "";
                tb_name.Text = "";
                tb_patronymic.Text = "";
                tb_class.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить запись");
            }
            ShowForm1();
        }

        void ShowForm1()
        {
            ListViewStudents.Items.Clear();
            foreach (Students student in Program.school.Students)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                student.Id.ToString(), student.Name, student.Surname,
                student.patronymic, student.Class
                });
                item.Tag = student;
                ListViewStudents.Items.Add(item);
            }
            ListViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (ListViewStudents.SelectedItems.Count == 1)
            {
                Students student = ListViewStudents.SelectedItems[0].Tag as Students;
                student.Surname = tb_surname.Text;
                student.Name = tb_name.Text;
                student.patronymic = tb_patronymic.Text;
                student.Class = tb_class.Text;
                Program.school.SaveChanges();
                ShowForm1();
            }
        }
    }
}
