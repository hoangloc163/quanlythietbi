using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;

namespace DataAccessLayer
{
    public class dbConnect
    {
        static SqlConnection conn;
        private String ConnectString = "";
       
        public dbConnect() //code ket noi
        {
            // sua lai chuoi ket noi cho phu hop database và sua lai AppConfig
            //conn = new SqlConnection("Data Source=JR163\\SQLEXPRESS;Initial Catalog=QLVT_test;Integrated Security=True");
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\QLVT_test");
            if (key != null) 
            {
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                var rk = localMachine.OpenSubKey("SOFTWARE\\QLVT_test");
                var DataBaseName = rk.GetValue("DatabaseName");
                var ComputerName = rk.GetValue("ComputerName");
                var ServerSQL = rk.GetValue("ServerName");
                conn = new SqlConnection("Data Source=" + ServerSQL.ToString() + ";Initial Catalog=" + DataBaseName.ToString() + ";Integrated Security=True");
            }
        }

        public string Connect2DB(string sername, string DatabaseName, string message)
        {
            try
            {
                ConnectString = "Data Source=" + sername + ";Initial Catalog=" + DatabaseName + ";Integrated Security=True";
                conn = new SqlConnection(ConnectString);
                conn.Open();

                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\QLVT_test");
                
                key.SetValue("ServerName", sername);
                key.SetValue("DatabaseName", DatabaseName);
                key.SetValue("ComputerName", sername.Substring(0,sername.IndexOf("\\")));
                key.SetValue("WSLCheck", "Off");
                key.SetValue("WSLValue", "100");
                key.SetValue("WHSDCheck", "Off");
                key.SetValue("WHSDValue", "30");
                key.SetValue("MCNCheck", "Off");
                key.SetValue("WHHCheck", "Off");
                key.SetValue("MCNValue", "15000000");

                key.Close();

                message = "Kết nối thành công";
                return message;
            }
            catch (Exception ex)
            {
                string mess_erro = ex.ToString();
                message = "Lỗi kết nối : " + mess_erro;
                return message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                //this.Close();
            }
        }

        public DataTable GetDataOriginal(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetData(string procName, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public int ExecuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
        public int ExecuteSQL(string procName, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            conn.Open();
            int row = cmd.ExecuteNonQuery(); //NonQuery chi dung cho insert,update,delete
            conn.Close();
            return row;
        }

        public string ExecuteSQL1(string procName, SqlParameter[] para, string check)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
                cmd.Parameters.Add("@kiemtra", SqlDbType.Bit).Direction = ParameterDirection.Output;
            }
            conn.Open();
            cmd.ExecuteNonQuery(); //NonQuery chi dung cho insert,update,delete
            check = cmd.Parameters["@kiemtra"].Value.ToString();
            conn.Close();
            return check;
        }

        public string ExecuteSQL3(string procName, SqlParameter[] para, string mess)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
                cmd.Parameters.Add("@message", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            }
            conn.Open();
            //conn.InfoMessage += new SqlInfoMessageEventHandler(con_InfoMessage);  //(1)
            cmd.ExecuteNonQuery();
            mess = cmd.Parameters["@message"].Value.ToString();
            conn.Close();
            return mess;  //return error de tra len form hien thi
        }
    }
}
