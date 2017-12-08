using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace CourseSelect
{
    public class DBHelper
    {
        //连接字段
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CourseSelect.ConnectionString"].ConnectionString;

        public static int ExecNonQuery(string strSQL)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strSQL, conn);
                return cmd.ExecuteNonQuery();


            }
        }



        public static DataTable GetTable(string strSQL)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];

            }

        }


        public static OleDbDataReader GetReader(string strSQL)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }



    }
}
