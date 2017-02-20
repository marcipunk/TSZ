using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TSZ
{
    class TehenData
    {
        //private List<Tehen> tehenek;
        public static DataTable tehenTable ;
        

        static TehenData()
        {
            tehenTable = new DataTable { TableName = "tehenek" };
            tehenTable.Columns.Add(new DataColumn("id", typeof(int)));
            tehenTable.Columns.Add(new DataColumn("nev", typeof(string)));
            tehenTable.Columns.Add(new DataColumn("tejhozam", typeof(int)));
            tehenTable.Columns.Add(new DataColumn("fajta", typeof(Fajta)));
        }

    }
}
