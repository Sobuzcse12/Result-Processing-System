using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace ResultProcessing
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBatch batch = new AddBatch();
            batch.Visible = true;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent();
            student.Visible = true;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse course = new AddCourse();
            course.Visible = true;
        }

        private void assignCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignCourse course = new AssignCourse();
            course.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDisipline discipline = new CreateDisipline();
            discipline.Visible = true;
        }

        private void sessionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksEntry_SubWise_Sessional sessional = new MarksEntry_SubWise_Sessional();
            sessional.Visible = true;
        }

        private void theoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksEntry_SubWise_Theory theory = new MarksEntry_SubWise_Theory();
            theory.Visible = true;
        }

        private void studentWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarksEntry_StudentWise student = new MarksEntry_StudentWise();
            student.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void marksEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
