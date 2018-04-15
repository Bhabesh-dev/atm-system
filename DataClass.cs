using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace atmsystem
{
    public static class DataClass
    {

        //Add here for datasetup
       public static DataTable Data()

        {
            DataTable Log_in = new DataTable();

            Log_in.Columns.Add("user", typeof(string));
            Log_in.Columns.Add("Firstname", typeof(string));
            Log_in.Columns.Add("account_no", typeof(string));
            Log_in.Columns.Add("pin", typeof(string));
            Log_in.Columns.Add("balance", typeof(string));
            Log_in.Rows.Add(1, "Bhabesh", 1234, 1234, 100000);
            Log_in.Rows.Add(2, "Bhabesh1", 12341, 12341, 200000);
            Log_in.Rows.Add(3, "Bhabesh2", 12342, 12342, 100000);
            Log_in.Rows.Add(4, "Bhabesh3", 12343, 12343, 300000);
            Log_in.Rows.Add(5, "Bhabesh4", 12345, 12345, 500000);

            return Log_in;

        }


    }
}
