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
using Model;
using System.Data.OleDb;


namespace View
{
    public partial class AddStudent : Form
    {
        Record record = new Record();
        BatchController controller = new BatchController();
        StudentController sc = new StudentController();
        DataTable dt1;
        
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.resultProcessingDataDataSet);

        }
        public void loadBatch() {
            try
            {
                string getQuery = "select * from BatchTable";

                OleDbConnection connect = new OleDbConnection(record.getConnection());
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();


                while (dr.Read())
                {
                    
                    AddStudent_BatchName_ComboBox.Items.Add(dr.GetString(0));
                }
                
                connect.Close();

                /*
                String[] batch = new String[100];
                batch = controller.batchRecord();
                int i = 0;
                while (batch[i] != null)
                {
                    AddStudent_BatchName_ComboBox.Items.Add(batch[i]);
                    i++;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadRoll()
        {
            String batch = AddStudent_BatchName_ComboBox.Text;
            String term = AddStudent_Term_ComboBox.Text;

            if (batch.Equals("") || term.Equals("") || batch.Equals(null) || term.Equals(null))
            {
                studentTableDataGridView.DataSource = null;
            }
            else
            {
                bool flag = controller.BTExists(batch, term);

                if (flag == true)
                {
                    studentTableDataGridView.DataSource = null;
                    StudentController sc = new StudentController();
                    DataTable table = sc.getStudentData(batch);

                    studentTableDataGridView.DataSource = table;
                    dt1 = table;
                }
                else
                    studentTableDataGridView.DataSource = null;
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resultProcessingDataDataSet.StudentTable' table. You can move, or remove it, as needed.
            LoadWindow();
        }
        public void LoadWindow() {
            this.studentTableTableAdapter.Fill(this.resultProcessingDataDataSet.StudentTable);
            studentTableDataGridView.DataSource = null;
            loadBatch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.studentTableTableAdapter.Update(this.resultProcessingDataDataSet.StudentTable);

            String batch = AddStudent_BatchName_ComboBox.Text;
            String term = AddStudent_Term_ComboBox.Text;

            if (batch != "" && term != "")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Roll");
                dt.Columns.Add("Name");
                dt.Columns.Add("Credit");
                dt.Clear();

                int len = 0;
                len = studentTableDataGridView.Rows.Count;
                int i;
                DataRow dr;
                String temp;
                String temp1;
                try
                {
                    for (i = 0; i < len - 1; i++)
                    {
                        temp = studentTableDataGridView.Rows[i].Cells[0].Value.ToString();

                        temp1 = "";
                        for (int j = 0; j < 2; j++)
                        {
                            temp1 = temp1 + temp.ElementAt(j);
                        }

                        if (!temp1.Equals(batch))
                        {
                            MessageBox.Show("The Roll " + temp + " is not a valid Id of batch " + batch);
                            loadRoll();
                            return;
                        }

                        bool flag = sc.exists(temp);

                        if (flag == false)
                        {
                            sc.SaveStudentList(temp, studentTableDataGridView.Rows[i].Cells[1].Value.ToString(), studentTableDataGridView.Rows[i].Cells[2].Value.ToString());
                            //MessageBox.Show("Smrity");
                        }
                        else
                        {
                            dr = dt.NewRow();
                            dr["Roll"] = studentTableDataGridView.Rows[i].Cells[0].Value.ToString();
                            dr["Name"] = studentTableDataGridView.Rows[i].Cells[1].Value.ToString();
                            dr["Credit"] = studentTableDataGridView.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(dr);
                        }
                    }
                    
                    sc.updateTable(dt);
                    this.studentTableTableAdapter.Dispose();
                    this.studentTableTableAdapter.Fill(this.resultProcessingDataDataSet.StudentTable);
                    studentTableDataGridView.DataSource = null;
                    //loadBatch();
                    AddStudent_BatchName_ComboBox.Text = batch;
                    AddStudent_Term_ComboBox.Text = term;
                    loadRoll();
                    MessageBox.Show("Data Table Updated !");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddStudent_AddNewStudent_Btn_Click(object sender, EventArgs e)
        {
            //DataTable dt = this.resultProcessingDataDataSet.StudentTable;
            try
            {
                DataRow dr = dt1.NewRow();
                dr["Roll"] = "0";
                dt1.Rows.Add(dr);
                studentTableDataGridView.DataSource = dt1;
            }catch(Exception){}
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Exit_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudent_Term_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRoll();
        }

        private void AddStudent_BatchName_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRoll();
        }

        private void AddStudent_DeleteStudent_Btn_Click(object sender, EventArgs e)
        {
           // DataRow row = studentTableDataGridView;
            try
            {
                int selectedIndex = studentTableDataGridView.CurrentCell.RowIndex;

                String roll = studentTableDataGridView.Rows[selectedIndex].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure to delete " + roll + "?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (selectedIndex > -1)
                    {
                        bool flag = sc.SDelete(roll);
                        if (flag == true)
                        {
                            MessageBox.Show("Student Deleted " + roll);
                            studentTableDataGridView.Rows.RemoveAt(selectedIndex);
                            studentTableDataGridView.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Deletion Failed");
                        }
                    }
                    else
                        MessageBox.Show("Select a row");
                }
            }
            catch (Exception) { }
        }

        private void AddStudent_SaveStudent_Btn_Click(object sender, EventArgs e)
        {
            this.studentTableTableAdapter.Update(this.resultProcessingDataDataSet.StudentTable);

            String batch = AddStudent_BatchName_ComboBox.Text;
            String term = AddStudent_Term_ComboBox.Text;

            if (batch != "" && term != "")
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Roll");
                dt.Columns.Add("Name");
                dt.Columns.Add("Credit");
                dt.Clear();

                int len = 0;
                len = studentTableDataGridView.Rows.Count;
                int i;
                DataRow dr;
                String temp;
                String temp1;
                try
                {
                    for (i = 0; i < len - 1; i++)
                    {
                        temp = studentTableDataGridView.Rows[i].Cells[0].Value.ToString();

                        temp1 = "";
                        for (int j = 0; j < 2; j++)
                        {
                            temp1 = temp1 + temp.ElementAt(j);
                        }

                        if (!temp1.Equals(batch))
                        {
                            MessageBox.Show("The Roll " + temp + " is not a valid Id of batch " + batch);
                            loadRoll();
                            return;
                        }

                        bool flag = sc.exists(temp);

                        if (flag == false)
                        {
                            sc.SaveStudentList(temp, studentTableDataGridView.Rows[i].Cells[1].Value.ToString(), studentTableDataGridView.Rows[i].Cells[2].Value.ToString());
                            //MessageBox.Show("Smrity");
                        }
                        else
                        {
                            dr = dt.NewRow();
                            dr["Roll"] = studentTableDataGridView.Rows[i].Cells[0].Value.ToString();
                            dr["Name"] = studentTableDataGridView.Rows[i].Cells[1].Value.ToString();
                            dr["Credit"] = studentTableDataGridView.Rows[i].Cells[2].Value.ToString();
                            dt.Rows.Add(dr);
                        }
                    }

                    sc.updateTable(dt);
                    MessageBox.Show("Data Table Updated !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
