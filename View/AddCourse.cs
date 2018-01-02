using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class AddCourse : Form
    {
        CourseController controller = new CourseController();

        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Save_Btn_Click(object sender, EventArgs e)
        {

            
                DisciplineController disc = new DisciplineController();

                bool f = disc.DExists();

                if (f == true)
                {
                    String code = AddCourse_CourseCode_txt.Text;
                    String hour = AddCourse_CreditHours_txt.Text;
                    String title = AddCourse_CourseName_txt.Text;


                    if (code.Equals("") || hour.Equals("") || title.Equals(""))
                    {
                        return;
                    }

                    if (!AddCourse_Sessional_RadioBtn.Checked && !AddCourse_Theory_RadioBtn.Checked) { return; }

                    bool flag = controller.CExists(code);

                    if (flag == false)
                    {
                        if (AddCourse_Theory_RadioBtn.Checked)
                        {
                            controller.saveCourse(code, hour, title, "");
                        }
                        if (AddCourse_Sessional_RadioBtn.Checked)
                        {
                            controller.saveCourse(code, hour, title, "yes");
                        }
                        MessageBox.Show("Course Saved");
                        AddCourse_CourseCode_txt.Text = "";
                        AddCourse_CourseName_txt.Text = "";
                        AddCourse_CreditHours_txt.Text = "";
                    }
                    else
                        MessageBox.Show("Course Already Exists");
                }
                else
                {
                    MessageBox.Show("You have not created any Discipline yet !!!", "Warning", MessageBoxButtons.OK);
                    AddCourse_CourseCode_txt.Text = "";
                    AddCourse_CourseName_txt.Text = "";
                    AddCourse_CreditHours_txt.Text = "";
                }
        }

        private void AddCourse_Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void AddCourse_Theory_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
