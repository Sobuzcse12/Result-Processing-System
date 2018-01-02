using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class Discipline : Record
    {
        public string Name = "";
        public string Session = "";
        public string Code = "";
        OleDbDataAdapter DataAdapterTest;
        DataSet BooksDataSet;
        public Discipline()
        {

        }

        public Discipline(string name, string session,String code)
        {
            this.Name = name;
            this.Session = session;
            this.Code = code;
        }

        public Boolean create()
        {
            string dbcommand = "INSERT into DisciplineTable values('" + Name + "','" + Code + "','" + Session + "')";
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

        public static Discipline getDiscipline()
        {
            string getQuery = "select * from DisciplineTable";
            Discipline batch = new Discipline();
            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                batch.Name = dr.GetString(0);
                batch.Session = dr.GetString(2);
                batch.Code = dr.GetString(1);
            }

            connect.Close();
            return batch;
        }
        public bool DisciplineExists()
        {
            bool exist = false;

            string getQuery = "select * from DisciplineTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
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

        public void deleteDiscipline()
        {
            string dbcommand = "delete * from DisciplineTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }
    }
}
