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
    public partial class MarksEntry_StudentWise : Form
    {
        Record record = new Record();
        StudentController controller = new StudentController();

        public MarksEntry_StudentWise()
        {
            InitializeComponent();
        }

        private void theoryCourseTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.theoryCourseTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resultProcessingDataDataSet1);

        }

        private void MarksEntry_StudentWise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultProcessingDataDataSet2.SessionalCourseTable' table. You can move, or remove it, as needed.
            this.sessionalCourseTableTableAdapter1.Fill(this.resultProcessingDataDataSet2.SessionalCourseTable);
            // TODO: This line of code loads data into the 'resultProcessingDataDataSet2.TheoryCourseTable' table. You can move, or remove it, as needed.
            this.theoryCourseTableTableAdapter1.Fill(this.resultProcessingDataDataSet2.TheoryCourseTable);
            
            theoryCourseTableDataGridView.DataSource = null;
            sessionalCourseTableDataGridView.DataSource = null;

            loadRoll();
        }

        private void MarksEntry_StudentWise_ID_ComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = MarksEntry_StudentWise_ID_ComboBx.Text;

            if(id != null || !id.Equals("")){

                DataTable dt1 = controller.getCourseTakenStudentInfoTable(id);
                DataTable dt2 = controller.getCourseTakenStudentInfoSessionalTable(id);

                theoryCourseTableDataGridView.DataSource = dt1;
                sessionalCourseTableDataGridView.DataSource = dt2;
            }
        }

        public void loadRoll()
        {
            try
            {
                string getQuery = "select * from StudentTable";

                OleDbConnection connect = new OleDbConnection(record.getConnection());
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();


                while (dr.Read())
                {

                    MarksEntry_StudentWise_ID_ComboBx.Items.Add(dr.GetString(0));
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MarksEntry_StudentWise_Save_Btn_Click(object sender, EventArgs e)
        {
             String id = MarksEntry_StudentWise_ID_ComboBx.Text;

             if (!id.Equals(""))
             {
                 DataTable table = new DataTable();
                 table.Columns.Add("CourseTaken");
                 table.Columns.Add("CT");
                 table.Columns.Add("Attendance");
                 table.Columns.Add("Final");
                 table.Columns.Add("Total");
                 table.Columns.Add("Grade");

                 DataRow dRow;
                 int len = 0;

                 try
                 {
                     len = theoryCourseTableDataGridView.Rows.Count;

                     for (int i = 0; i < len - 1; i++)
                     {
                         dRow = table.NewRow();

                         dRow["CourseTaken"] = theoryCourseTableDataGridView.Rows[i].Cells[0].Value.ToString();
                         dRow["CT"] = theoryCourseTableDataGridView.Rows[i].Cells[1].Value.ToString();
                         dRow["Attendance"] = theoryCourseTableDataGridView.Rows[i].Cells[2].Value.ToString();
                         dRow["Final"] = theoryCourseTableDataGridView.Rows[i].Cells[3].Value.ToString();
                         dRow["Total"] = theoryCourseTableDataGridView.Rows[i].Cells[4].Value.ToString();
                         dRow["Grade"] = theoryCourseTableDataGridView.Rows[i].Cells[5].Value.ToString();

                         table.Rows.Add(dRow);
                     }

                     table = controller.getStudentGradeTable(table, id, len - 1);

                     theoryCourseTableDataGridView.DataSource = table;
                 }catch(Exception){}

                 DataTable table1 = new DataTable();
                 table1.Columns.Add("CourseTaken");
                 table1.Columns.Add("LabWork");
                 table1.Columns.Add("LabTest");
                 table1.Columns.Add("Attendence");
                 table1.Columns.Add("Vaiva");
                 table1.Columns.Add("Total");
                 table1.Columns.Add("Grade");

                 len = 0;
                 len = sessionalCourseTableDataGridView.Rows.Count;
                 DataRow dRow1;

                 try
                 {
                     for (int i = 0; i < len - 1; i++)
                     {
                         dRow1 = table1.NewRow();

                         dRow1["CourseTaken"] = sessionalCourseTableDataGridView.Rows[i].Cells[0].Value.ToString();
                         dRow1["LabWork"] = sessionalCourseTableDataGridView.Rows[i].Cells[1].Value.ToString();
                         dRow1["LabTest"] = sessionalCourseTableDataGridView.Rows[i].Cells[2].Value.ToString();
                         dRow1["Attendence"] = sessionalCourseTableDataGridView.Rows[i].Cells[3].Value.ToString();
                         dRow1["Vaiva"] = sessionalCourseTableDataGridView.Rows[i].Cells[4].Value.ToString();
                         dRow1["Total"] = sessionalCourseTableDataGridView.Rows[i].Cells[5].Value.ToString();
                         dRow1["Grade"] = sessionalCourseTableDataGridView.Rows[i].Cells[6].Value.ToString();

                         table1.Rows.Add(dRow1);
                     }

                     table1 = controller.getStudentGradeSessionalTable(table1, id, len - 1);
                     sessionalCourseTableDataGridView.DataSource = table1;
                 }
                 catch (Exception) { }

             }
        }
    }
}
