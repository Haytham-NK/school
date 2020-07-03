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
    public partial class assessments1 : Form
    {
        public assessments1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            assessment ball = new assessment();
            ball.assessment = tb_surname.Text;
            ball.Name = tb_name.Text;
            ball.patronymic = tb_patronymic.Text;
            ball.iditems = cb_item.Text;
            Program.school.assessment.Add(ball);
            Program.school.SaveChanges();
            ShowTeachercs();
        }
    }
}
