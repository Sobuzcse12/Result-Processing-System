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
using Controller;
using Model;

namespace View
{
    public partial class MarksEntry_SubWise_Theory : Form
    {
        Record record = new Record();
        CourseController controller = new CourseController();

        public MarksEntry_SubWise_Theory()
        {
            InitializeComponent();
        }

        private void MarksEntry_SubWise_Theory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultProcessingDataDataSet1.TheoryCourseTable' table. You can move, or remove it, as needed.
            this.theoryCourseTableTableAdapter.Fill(this.resultProcessingDataDataSet1.TheoryCourseTable);
            theoryCourseTableDataGridView.DataSource = null;
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
                    if (dr[3].ToString().Equals(""))
                        MarksEntry_Sub_Theory_CourseName_ComboBx.Items.Add(dr.GetString(2));
                }


                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void theoryCourseTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.theoryCourseTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resultProcessingDataDataSet1);

        }

        public void loadInfo()
        {
            String course = MarksEntry_Sub_Theory_CourseName_ComboBx.Text;

            if (course.Equals("") || course.Equals(null))
            {
                theoryCourseTableDataGridView.DataSource = null;
            }
            else
            {
                theoryCourseTableDataGridView.DataSource = null;
                CourseController sc = new CourseController();
                DataTable table = sc.getCourseTakenStudentTable(course);

                theoryCourseTableDataGridView.DataSource = table;
            }
        }

        private void MarksEntry_Sub_Theory_CourseName_ComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void MarksEntry_Sub_Theory_Save_Btn_Click(object sender, EventArgs e)
        {
            String course = MarksEntry_Sub_Theory_CourseName_ComboBx.Text;

            if(!course.Equals("")){
                DataTable table = new DataTable();
                table.Columns.Add("Roll");
                table.Columns.Add("CT");
                table.Columns.Add("Attendance");
                table.Columns.Add("Final");
                table.Columns.Add("Total");
                table.Columns.Add("Grade");

                DataRow dRow;

                int len = 0;
                len = theoryCourseTableDataGridView.Rows.Count;

                for (int i = 0; i < len-1 ; i++ ) {
                    dRow = table.NewRow();

                    dRow["Roll"] = theoryCourseTableDataGridView.Rows[i].Cells[0].Value.ToString();
                    dRow["CT"] = theoryCourseTableDataGridView.Rows[i].Cells[1].Value.ToString();
                    dRow["Attendance"] = theoryCourseTableDataGridView.Rows[i].Cells[2].Value.ToString();
                    dRow["Final"] = theoryCourseTableDataGridView.Rows[i].Cells[3].Value.ToString();
                    dRow["Total"] = theoryCourseTableDataGridView.Rows[i].Cells[4].Value.ToString();
                    dRow["Grade"] = theoryCourseTableDataGridView.Rows[i].Cells[5].Value.ToString();
                    
                    table.Rows.Add(dRow);
                }

                table = controller.getStudentGradeTable(table,course,len-1);
                theoryCourseTableDataGridView.DataSource = table;
            }
        }
    }
}

