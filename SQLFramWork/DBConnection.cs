using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLFramWork
{
    internal  static  class DBConnection
    {
        public static string ConnectionString { get; set; }
        private static SqlConnection connection;
        

        private static string CreatConnectionString(DataBase databas)
        {

            string _WINDOWS_CONNECTION = @"server = " + databas.ServerName + " ; Database=" + databas.DBName + " ; Integrated Security=true";
            string _AUTHORNECATION_CONNECTION = @"server = " + databas.ServerName + " ; Database=" + databas.DBName + "" +
                ";Integrated Security=false ; User ID = " + databas.Username + " ;Password = " + databas.UserPassword + " ";
            if (databas.IntegratedSecurit == true) { return _WINDOWS_CONNECTION; }
            else { return _AUTHORNECATION_CONNECTION; }

            
        }

        public static void CreateConnection(DataBase d)
        {
            DBConnection.ConnectionString = CreatConnectionString(d);
            connection = new SqlConnection(DBConnection.ConnectionString);
            
        }



        public static void OPenConnection()
        {
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
        }

        public static void CloseConnetion()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
        }


        public static DataTable Get(string command, SqlParameter[] paramter )
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = connection;


            if (paramter != null)
            {
                cmd.Parameters.AddRange(paramter);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);

            return table;
        }

        public static void Execute(string command, SqlParameter[] paramter )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = command;
            cmd.Connection = connection;


            if (paramter != null)
            {
                cmd.Parameters.AddRange(paramter);
            }

            cmd.ExecuteNonQuery();
        }

    }
}
