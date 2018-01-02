using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Model
{
    public class Batch : Record
    {
        public string Name = "";
        public string Term = "";
        public string Roll = "";
        OleDbDataAdapter DataAdapterTest;
        DataSet BooksDataSet;
        public Batch()
        {

        }

        public Batch(string name, String term)
        {
            this.Name = name;
            this.Term = term;
        }
        public Boolean create()
        {
            string dbcommand = "INSERT into BatchTable values('" + Name + "','" + Term + "')";
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

        public String[] getBatch()
        {
            string getQuery = "select * from BatchTable";
            
            String[] batch = new String[100];
            int i = 0;
            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                batch[i]= dr.GetString(0);
                i++;
            }
            batch[i] = null;
            connect.Close();
            return batch;
        }

        public bool batchExists(String batch)
        {
            bool exist = false;

            string getQuery = "select * from BatchTable";

            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();

            OleDbDataReader dr = dbCommand.ExecuteReader();

            while (dr.Read())
            {
                if (batch.Equals(dr[0].ToString()))
                {
                    exist = true;
                }
            }
            return exist;
        }

        public void deleteAllBatch()
        {
            string dbcommand = "delete * from BatchTable";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception) { }
        }
        public bool Xtra(String batch, String term)
        {
            bool exist = false;

            string getQuery = "select * from BatchTable";
            try
            {
                OleDbConnection connect = new OleDbConnection(Connection);
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();

                OleDbDataReader dr = dbCommand.ExecuteReader();

                while (dr.Read())
                {
                    if (batch.Equals(dr[0].ToString()) && term.Equals(dr[1].ToString()))
                    {
                        exist = true;
                    }
                }
            }catch(Exception){}
            return exist;
        }

    }
}
