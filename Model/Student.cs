using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class Student : Record
    {
        public string Roll = "";
        public string Name = "";
        public string CreditHour = "";
        
        OleDbDataAdapter DataAdapterTest;
        DataSet BooksDataSet;
        public Student()
        {

        }

        public Student(string roll)
        {
            this.Roll = roll;
            //this.Name = name;
            //this.CreditHour = credit;
        }
        public Student(string roll,String name,String credit)
        {
            this.Roll = roll;
            this.Name = name;
            this.CreditHour = credit;
        }

        public Boolean createSingleStudent()
        {
            string dbcommand = "INSERT into StudentTable values('" + Roll + "','"+Name+"','"+CreditHour+"')";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Boolean createStudent()
        {
            string dbcommand = "INSERT into StudentTable(Roll) values('" + Roll + "')";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public String getStudentCredit(String roll) {
            String credit = "";
            string getQuery = "select * from StudentTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (roll.Equals(dr[0].ToString()))
                {
                    if (!dr[2].ToString().Equals(null))
                        credit = dr[2].ToString();
                    break;
                }
            }
            return credit;
        }

        public bool studentExists(String roll) {
            bool exist = false;

            string getQuery = "select * from StudentTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read()) {
                if (roll.Equals(dr[0].ToString())) {
                    exist = true;
                }
            }
            return exist;
        }


        public DataTable getStudent(String batch)
        {
            string getQuery = "select * from StudentTable";
            
            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Roll");
            table.Columns.Add("StudentName");
            table.Columns.Add("Credit");
            String str,temp;
            int i;
            
            DataRow dRow;
            try
            {
                while (dr.Read())
                {
                    dRow = table.NewRow();

                    temp = "";
                    str = dr[0].ToString();
                    for (i = 0; i < 2; i++) {
                        temp = temp + str.ElementAt(i);
                    }
                    if (temp.Equals(batch))
                    {

                        if (dr[0].ToString() == null)
                            dRow["Roll"] = "";
                        else
                            dRow["Roll"] = dr[0].ToString();
                        if (dr[1].ToString() == null)
                            dRow["StudentName"] = "";
                        else
                            dRow["StudentName"] = dr[1].ToString();
                        if (dr[2].ToString() == null)
                            dRow["Credit"] = "";
                        else
                            dRow["Credit"] = dr[2].ToString();

                        table.Rows.Add(dRow);
                    }
                }
            }catch(Exception){}
            
            connect.Close();
            return table;
        }

        public Student update(DataTable dt)
        {
            string dbcommand;

            int len = dt.Rows.Count;
            int i;

            for (i = 0; i < len; i++)
            {
                dbcommand = "Update StudentTable set StudentName = '" + dt.Rows[i][1].ToString() + "' , Credit = '" + dt.Rows[i][2].ToString() + "' where Roll = '" + dt.Rows[i][0].ToString() + "'";
                //dbcommand = "Update StudentTable set (StudentName,Credit) values('" + dt.Rows[1].ToString() + "','" + dt.Rows[2].ToString() + "') where Roll = '" + dt.Rows[0].ToString() + "'";
                
                try
                {
                    DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                    BooksDataSet = new DataSet();
                    DataAdapterTest.Fill(BooksDataSet);
                    DataAdapterTest.Dispose();
                }
                catch (Exception) { }
            }
            return null;
        }

        public Boolean deleteStudent(String roll)
        {
            string dbcommand = "delete from StudentTable where Roll = '" + roll + "'";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
                return true;
            }catch(Exception){}

            return false;
        }
        public void deleteAllStudent() {
            string dbcommand = "delete * from StudentTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }

        public DataTable getCourseTakenStudentInfo(String id)
        {
            string getQuery = "select * from TheoryCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("CourseTaken");
            table.Columns.Add("CT");
            table.Columns.Add("Attendance"); 
            table.Columns.Add("Final");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;

            while (dr.Read())
            {
                if (dr[0].ToString().Equals(id))
                {
                    dRow = table.NewRow();

                    dRow["CourseTaken"] = dr[1].ToString();
                    dRow["CT"] = dr[2].ToString();
                    dRow["Attendance"] = dr[3].ToString();
                    dRow["Final"] = dr[4].ToString();
                    dRow["Total"] = dr[5].ToString();
                    dRow["Grade"] = dr[6].ToString();

                    table.Rows.Add(dRow);
                }
            }

            return table;
        }

        public DataTable getCourseTakenStudentInfoSessional(String id)
        {
            string getQuery = "select * from SessionalCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("CourseTaken");
            table.Columns.Add("LabWork");
            table.Columns.Add("LabTest");
            table.Columns.Add("Attendence");
            table.Columns.Add("Vaiva");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;

            while (dr.Read())
            {
                if (dr[0].ToString().Equals(id))
                {
                    dRow = table.NewRow();

                    dRow["CourseTaken"] = dr[1].ToString();
                    dRow["LabWork"] = dr[2].ToString();
                    dRow["LabTest"] = dr[3].ToString();
                    dRow["Attendence"] = dr[4].ToString();
                    dRow["Vaiva"] = dr[5].ToString();
                    dRow["Total"] = dr[6].ToString();
                    dRow["Grade"] = dr[7].ToString();

                    table.Rows.Add(dRow);
                }
            }

            return table;
        }

        public DataTable getStudentGrade(DataTable dt, String id, int len)
        {
            DataTable table = new DataTable();

            table.Columns.Add("CourseTaken");
            table.Columns.Add("CT");
            table.Columns.Add("Attendance");
            table.Columns.Add("Final");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;
            string dbcommand;

            for (int i = 0; i < len; i++)
            {

                dRow = table.NewRow();

                dRow["CourseTaken"] = dt.Rows[i][0].ToString();
                dRow["CT"] = dt.Rows[i][1].ToString();
                dRow["Attendance"] = dt.Rows[i][2].ToString();
                dRow["Final"] = dt.Rows[i][3].ToString();

                String[] output = getTotal(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(),"0.0");

                dRow["Total"] = output[0];
                dRow["Grade"] = output[1];

                table.Rows.Add(dRow);

                dbcommand = "Update TheoryCourseTable set CT = '" + dt.Rows[i][1].ToString() + "' , Attendance = '" + dt.Rows[i][2].ToString() + "', Final = '" + dt.Rows[i][3].ToString() + "', Total = '" + output[0] + "', Grade = '" + output[1] + "' where CourseTaken = '" + dt.Rows[i][0].ToString() + "' and Roll = '" + id + "'";

                try
                {
                    DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                    BooksDataSet = new DataSet();
                    DataAdapterTest.Fill(BooksDataSet);
                    DataAdapterTest.Dispose();
                }
                catch (Exception)
                {
                    Console.Write("peep");
                }

            }

            return table;
        }

        public DataTable getStudentGradeSessional(DataTable dt, String id, int len)
        {
            DataTable table = new DataTable();

            table.Columns.Add("CourseTaken");
            table.Columns.Add("LabWork");
            table.Columns.Add("LabTest");
            table.Columns.Add("Attendence");
            table.Columns.Add("Vaiva");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;
            string dbcommand;

            for (int i = 0; i < len; i++)
            {

                dRow = table.NewRow();

                dRow["CourseTaken"] = dt.Rows[i][0].ToString();
                dRow["LabWork"] = dt.Rows[i][1].ToString();
                dRow["LabTest"] = dt.Rows[i][2].ToString();
                dRow["Attendence"] = dt.Rows[i][3].ToString();
                dRow["Vaiva"] = dt.Rows[i][4].ToString();

                String[] output = getTotal(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());

                dRow["Total"] = output[0];
                dRow["Grade"] = output[1];

                table.Rows.Add(dRow);

                dbcommand = "Update SessionalCourseTable set LabWork = '" + dt.Rows[i][1].ToString() + "' , LabTest = '" + dt.Rows[i][2].ToString() + "' , Attendence = '" + dt.Rows[i][3].ToString() + "', Vaiva = '" + dt.Rows[i][4].ToString() + "', Total = '" + output[0] + "', Grade = '" + output[1] + "' where CourseTaken = '" + dt.Rows[i][0].ToString() + "' and Roll = '" + id + "'";

                try
                {
                    DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                    BooksDataSet = new DataSet();
                    DataAdapterTest.Fill(BooksDataSet);
                    DataAdapterTest.Dispose();
                }
                catch (Exception)
                {
                    Console.Write("peep");
                }

            }

            return table;
        }

        public String[] getTotal(String ct, String att, String f, String l = null)
        {
            String[] output = new String[2];
            try
            {
                double ctMark = Double.Parse(ct);
                double attendence = Double.Parse(att);
                double final = Double.Parse(f);
                double lab = Double.Parse(l);

                double total = ctMark + attendence + final + lab;
                output[0] = total.ToString();

                if (total >= 80.0)
                {
                    output[1] = "A+";
                }
                else if (total >= 75.0 && total < 80.0)
                {
                    output[1] = "A";
                }
                else if (total >= 70.0 && total < 75.0)
                {
                    output[1] = "A-";
                }
                else if (total >= 65.0 && total < 70.0)
                {
                    output[1] = "B+";
                }
                else if (total >= 60.0 && total < 65.0)
                {
                    output[1] = "B";
                }
                else if (total >= 55.0 && total < 60.0)
                {
                    output[1] = "C+";
                }
                else if (total >= 50.0 && total < 55.0)
                {
                    output[1] = "C";
                }
                else if (total >= 40.0 && total < 50.0)
                {
                    output[1] = "D";
                }
                else
                {
                    output[1] = "F";
                }
            }
            catch (Exception) { }
            return output;
        }
    }
}
