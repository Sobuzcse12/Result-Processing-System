using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;
using System.Data.OleDb;

namespace View
{
    public partial class AssignCourse : Form
    {
        Record record = new Record();
        CourseController controller = new CourseController();

        public AssignCourse()
        {
            InitializeComponent();
        }

        private void AssignCourse_Remove_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                String item = AssignCourse_CourseTaken_ListBox.SelectedItem.ToString();
                AssignCourse_CourseTaken_ListBox.Items.Remove(item);
            }catch(Exception){}
        }

        private void AssignCourse_Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void loadRoll() {
            try
            {
                string getQuery = "select * from StudentTable";

                OleDbConnection connect = new OleDbConnection(record.getConnection());
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();


                while (dr.Read())
                {

                    AssignCourse_Roll_ComboBox.Items.Add(dr.GetString(0));
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignCourse_Load(object sender, EventArgs e)
        {
            loadRoll();

            String[] str = controller.getCourseTitle();
            int i = 0;

            while (str[i] != null)
            {
                AssignCourse_CourseList_ListBox.Items.Add(str[i]);
                i++;
            }
        }

        private void AssignCourse_Roll_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String roll = AssignCourse_Roll_ComboBox.Text;
            String[] list;
            int i = 0;
            AssignCourse_CourseTaken_ListBox.Items.Clear();

            if (!roll.Equals("")) {
                list = controller.getStudentCourseList(roll);
                while (list[i] != null) {
                    AssignCourse_CourseTaken_ListBox.Items.Add(list[i]);
                    i++;
                }
            }
        }

        private void AssignCourse_Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                String roll = AssignCourse_Roll_ComboBox.Text;
                if (roll != "")
                {
                    String item = AssignCourse_CourseList_ListBox.SelectedItem.ToString();
                    AssignCourse_CourseTaken_ListBox.Items.Add(item);
                }
                else
                    MessageBox.Show("Please Select A Roll");
            }catch(Exception){}
        }

        private void AssignCourse_Save_Btn_Click(object sender, EventArgs e)
        {
            String roll = AssignCourse_Roll_ComboBox.Text;

            int len = AssignCourse_CourseTaken_ListBox.Items.Count;

            
            String[] sub = new String[len];

            for (int i = 0; i < len; i++ ) {
                sub[i] = AssignCourse_CourseTaken_ListBox.Items[i].ToString();
                
            }

            if (len > 0 && !roll.Equals("")) {
                String output = controller.addStudentCourse(roll,sub,len);
                MessageBox.Show(output);
            }
        }
    }
}
