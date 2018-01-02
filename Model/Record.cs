using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Record
    {
        //public static string Connection = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"data source=D:\Study\Programming Output\Visual Studio\DataBaseFile\ResultProcessingData.mdb";
        public static string Connection = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=E:\Second Year First Term\Advance Programming Laboratory\ResultProcessingSystem\View\ResultProcessingData.mdb";
        public String getConnection() {
            return Connection;
        }
    }
}
