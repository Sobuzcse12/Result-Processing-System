using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class Course : Record
    {
        public string Code = "";
        public string Hour = "";
        public string Title = "";
        public string sessional = "";
        OleDbDataAdapter DataAdapterTest;
        DataSet BooksDataSet;
        public Course()
        {

        }

        public Course(string code, string hour, String title,String ses)
        {
            this.Code = code;
            this.Hour = hour;
            this.Title = title;
            this.sessional = ses;
        }

        public Boolean createCourse()
        {
            string dbcommand = "INSERT into CourseTable values('" + Code + "','" + Hour + "','" + Title + "','"+sessional+"')";
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

        public String[] getCourse()
        {
            string getQuery = "select * from CourseTable";
            Discipline batch = new Discipline();
            String[] course = new String[100];
            int i = 0;

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                course[i] = dr[2].ToString();
                i++;
            }
            course[i] = null;

            connect.Close();
            return course;
        }

        public String getSubjectCredit(String sub)
        {
            String credit = "";
            string getQuery = "select * from CourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (sub.Equals(dr[2].ToString()))
                {
                    if (!dr[1].ToString().Equals(null))
                        credit = dr[1].ToString();
                    break;
                }
            }
            return credit;
        }

        public float getStudentTotalCredit(String roll)
        {
            String credit = "";
            float total = 0;
            string getQuery = "select * from TheoryCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (roll.Equals(dr[0].ToString()))
                {
                    credit = getSubjectCredit(dr[1].ToString());
                    total = total + float.Parse(credit);
                }
            }
            getQuery = "select * from SessionalCourseTable";

            connect = new OleDbConnection(Connection);
            dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (roll.Equals(dr[0].ToString()))
                {
                    credit = getSubjectCredit(dr[1].ToString());
                    total = total + float.Parse(credit);
                }
            }

            return total;
        }

        public String[] getStudentCourse(String roll)
        {
            string getQuery = "select * from TheoryCourseTable";
            Discipline batch = new Discipline();
            String[] course = new String[100];
            int i = 0;

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].Equals(roll))
                {
                    course[i] = dr[1].ToString();
                    i++;
                }
            }

            getQuery = "select * from SessionalCourseTable";

            connect = new OleDbConnection(Connection);
            dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].Equals(roll))
                {
                    course[i] = dr[1].ToString();
                    i++;
                }
            }

            course[i] = null;

            connect.Close();
            return course;
        }
        public bool CourseExists(String code)
        {
            bool exist = false;

            string getQuery = "select * from CourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if(dr[0].Equals(code))
                    exist = true;
            }
            return exist;
        }

        public bool StudentCourseExists(String roll , String code)
        {
            bool exist = false;

            string getQuery = "select * from TheoryCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].Equals(code) && dr[0].Equals(roll))
                    exist = true;
            }
            getQuery = "select * from SessionalCourseTable";

            connect = new OleDbConnection(Connection);
            dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[1].Equals(code) && dr[0].Equals(roll))
                    exist = true;
            }

            return exist;
        }

        public Discipline update()
        {
            return null;
        }

        public Boolean delete()
        {
            return true;
        }
        public void deleteAllCourse()
        {
            string dbcommand = "delete * from CourseTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }

        public void saveStudentCourse(String roll,String course) {
            string dbcommand = "INSERT into TheoryCourseTable(Roll, CourseTaken) values('" + roll + "','" + course + "')";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }
        public void saveSessionalCourse(String roll, String course)
        {
            string dbcommand = "INSERT into SessionalCourseTable(Roll, CourseTaken) values('" + roll + "','" + course + "')";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }
        public void deleteStudentCourseTable() {
            string dbcommand = "Delete * from TheoryCourseTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
            dbcommand = "Delete * from SessionalCourseTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }

        public bool courseIsTheory(String course) {
            bool flag = false;
            string temp = "";
            string getQuery = "select * from CourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (dr[2].Equals(course)) {
                    temp = dr[3].ToString();
                    break;
                }
            }
            if (temp.Equals("")) {
                flag = true;
            }
            return flag;
        }

        public DataTable getCourseTakenStudentInfo(String course)
        {
            string getQuery = "select * from TheoryCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Roll");
            table.Columns.Add("CT");
            table.Columns.Add("Attendance");
            table.Columns.Add("Final");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;

            while (dr.Read())
            {
                if (dr[1].ToString().Equals(course))
                {
                    dRow = table.NewRow();

                    dRow["Roll"] = dr[0].ToString();
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

        public DataTable getCourseTakenStudentInfoSessional(String course)
        {
            string getQuery = "select * from SessionalCourseTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("Roll");
            table.Columns.Add("LabWork");
            table.Columns.Add("LabTest");
            table.Columns.Add("Attendence");
            table.Columns.Add("Vaiva");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;

            while (dr.Read())
            {
                if (dr[1].ToString().Equals(course))
                {
                    dRow = table.NewRow();

                    dRow["Roll"] = dr[0].ToString();
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

        public DataTable getStudentGrade(DataTable dt , String course , int len) {
            DataTable table = new DataTable();

            table.Columns.Add("Roll");
            table.Columns.Add("CT");
            table.Columns.Add("Attendance");
            table.Columns.Add("Final");
            table.Columns.Add("Total");
            table.Columns.Add("Grade");

            DataRow dRow;
            string dbcommand;

            for (int i = 0; i < len; i++ )
            {
                
                    dRow = table.NewRow();

                    dRow["Roll"] = dt.Rows[i][0].ToString();
                    dRow["CT"] = dt.Rows[i][1].ToString();
                    dRow["Attendance"] = dt.Rows[i][2].ToString();
                    dRow["Final"] = dt.Rows[i][3].ToString();

                    String[] output = getTotal(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(),"0");
                
                    dRow["Total"] = output[0];
                    dRow["Grade"] = output[1];

                    table.Rows.Add(dRow);

                    dbcommand = "Update TheoryCourseTable set CT = '" + dt.Rows[i][1].ToString() + "' , Attendance = '" + dt.Rows[i][2].ToString() + "', Final = '" + dt.Rows[i][3].ToString() + "', Total = '" + output[0] + "', Grade = '" + output[1] + "' where Roll = '" + dt.Rows[i][0].ToString() + "' and CourseTaken = '"+course+"'";

                    try
                    {
                        DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                        BooksDataSet = new DataSet();
                        DataAdapterTest.Fill(BooksDataSet);
                        DataAdapterTest.Dispose();
                    }
                    catch (Exception) {
                        Console.Write("peep");
                    }
                
            }

            return table;
        }

        public DataTable getStudentGradeSessional(DataTable dt, String course, int len)
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
            string dbcommand;

            for (int i = 0; i < len; i++)
            {

                dRow = table.NewRow();

                dRow["Roll"] = dt.Rows[i][0].ToString();
                dRow["LabWork"] = dt.Rows[i][1].ToString();
                dRow["LabTest"] = dt.Rows[i][2].ToString();
                dRow["Attendence"] = dt.Rows[i][3].ToString();
                dRow["Vaiva"] = dt.Rows[i][4].ToString();

                String[] output = getTotal(dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString());

                dRow["Total"] = output[0];
                dRow["Grade"] = output[1];

                table.Rows.Add(dRow);

                dbcommand = "Update SessionalCourseTable set LabWork = '" + dt.Rows[i][1].ToString() + "' , LabTest = '" + dt.Rows[i][2].ToString() + "' , Attendence = '" + dt.Rows[i][3].ToString() + "', Vaiva = '" + dt.Rows[i][4].ToString() + "', Total = '" + output[0] + "', Grade = '" + output[1] + "' where Roll = '" + dt.Rows[i][0].ToString() + "' and CourseTaken = '" + course + "'";

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

        public String[] getTotal(String ct, String att , String f , String l = null) {
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
            }catch(Exception ){}
            return output;
        }

    }
}
