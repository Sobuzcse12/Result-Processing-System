using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Model;
using Controller;

namespace View
{
    public partial class MarksEntry_SubWise_Sessional : Form
    {
        Record record = new Record();
        CourseController controller = new CourseController();

        public MarksEntry_SubWise_Sessional()
        {
            InitializeComponent();
        }

        private void sessionalCourseTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sessionalCourseTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resultProcessingDataDataSet1);

        }

        private void MarksEntry_SubWise_Sessional_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultProcessingDataDataSet1.SessionalCourseTable' table. You can move, or remove it, as needed.
            this.sessionalCourseTableTableAdapter.Fill(this.resultProcessingDataDataSet1.SessionalCourseTable);
            sessionalCourseTableDataGridView.DataSource = null;
            loadCourse();
        }

        public void loadCourse()
        {
            try
            {
                string getQuery = "select * from CourseTable";

                OleDbConnection connect = new OleDbConnection(record.getConnection());
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();

                while (dr.Read())
                {
                    if (!dr[3].ToString().Equals(""))
                        MarksEntry_Sub_Sessional_CourseName_ComboBx.Items.Add(dr.GetString(2));
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadInfo()
        {
            String course = MarksEntry_Sub_Sessional_CourseName_ComboBx.Text;

            if (course.Equals("") || course.Equals(null))
            {
                sessionalCourseTableDataGridView.DataSource = null;
            }
            else
            {
                sessionalCourseTableDataGridView.DataSource = null;
                CourseController sc = new CourseController();
                DataTable table = sc.getCourseTakenStudentTableSessional(course);

                sessionalCourseTableDataGridView.DataSource = table;
            }
        }

        private void MarksEntry_Sub_Sessional_CourseName_ComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void MarksEntry_Sub_Sessional_Save_Btn_Click(object sender, EventArgs e)
        {
            String course = MarksEntry_Sub_Sessional_CourseName_ComboBx.Text;

            if (!course.Equals(""))
            {
                DataTable table = new DataTable();
                table.Columns.Add("Roll");
                table.Columns.Add("LabWork");
                table.Columns.Add("LabTest");
                table.Columns.Add("Attendence");
                table.Columns.Add("Vaiva");
                table.Columns.Add("Total");
                table.Columns.Add("Grade");

                DataRow dRow;

                int len = 0;
                len = sessionalCourseTableDataGridView.Rows.Count;
                try
                {
                    for (int i = 0; i < len - 1; i++)
                    {
                        dRow = table.NewRow();

                        dRow["Roll"] = sessionalCourseTableDataGridView.Rows[i].Cells[0].Value.ToString();
                        dRow["LabWork"] = sessionalCourseTableDataGridView.Rows[i].Cells[1].Value.ToString();
                        dRow["LabTest"] = sessionalCourseTableDataGridView.Rows[i].Cells[2].Value.ToString();
                        dRow["Attendence"] = sessionalCourseTableDataGridView.Rows[i].Cells[3].Value.ToString();
                        dRow["Vaiva"] = sessionalCourseTableDataGridView.Rows[i].Cells[4].Value.ToString();
                        dRow["Total"] = sessionalCourseTableDataGridView.Rows[i].Cells[5].Value.ToString();
                        dRow["Grade"] = sessionalCourseTableDataGridView.Rows[i].Cells[6].Value.ToString();

                        table.Rows.Add(dRow);
                    }

                    table = controller.getStudentGradeTableSessional(table, course, len - 1);
                    sessionalCourseTableDataGridView.DataSource = table;
                }catch(Exception){}
            }
        }
    }
}
