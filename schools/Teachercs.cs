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
    public partial class Theachercs : Form
    {
        public Theachercs()
        {
            InitializeComponent();
        }

        private void cb_item_SelectedIndexChanged(object sender, EventArgs e)
        {   
             Items item = new Items();
            cb_item.DataSource = item;
            cb_item.DisplayMember = "2";
            cb_item.SelectedIndex = -1;
        }

        private void ListViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowTeachercs()
        {
            ListViewTeachers.Items.Clear();
            foreach (teachers teacher in Program.school.teachers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                teacher.Id.ToString(), teacher.Name, teacher.Surname,
                teacher.patronymic, teacher.iditems
                });
                item.Tag = teacher;
                ListViewTeachers.Items.Add(item);
            }
            ListViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (ListViewTeachers.SelectedItems.Count == 1)
            {
                teachers teacher = ListViewTeachers.SelectedItems[0].Tag as teachers;
                teacher.Surname = tb_surname.Text;
                teacher.Name = tb_name.Text;
                teacher.patronymic = tb_patronymic.Text;
                teacher.iditems = cb_item.Text;
                Program.school.SaveChanges();
                ShowTeachercs();
            }
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListViewTeachers.SelectedItems.Count == 1)
                {
                    teachers teacher = ListViewTeachers.SelectedItems[0].Tag as teachers;
                    Program.school.teachers.Remove(teacher);
                    Program.school.SaveChanges();
                }
                tb_surname.Text = "";
                tb_name.Text = "";
                tb_patronymic.Text = "";
                cb_item.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить запись");
            }
            ShowTeachercs();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            teachers teacher = new teachers();
            teacher.Surname = tb_surname.Text;
            teacher.Name = tb_name.Text;
            teacher.patronymic = tb_patronymic.Text;
            teacher.iditems = cb_item.Text;
            Program.school.teachers.Add(teacher);
            Program.school.SaveChanges();
            ShowTeachercs();
        }

        private void Учителя_Load(object sender, EventArgs e)
        {

        }
    }
}
