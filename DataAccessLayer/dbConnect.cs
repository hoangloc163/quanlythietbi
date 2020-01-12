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
        private SqlConnection conn;
        private String ConnectString = "";
        public dbConnect() //code ket noi
        {
        //    // sua lai chuoi ket noi cho phu hop database và sua lai AppConfig
        //    //conn = new SqlConnection("Data Source=DESKTOP-6JMGM38\\SQLEXPRESS;Initial Catalog=QLPT_test3;Integrated Security=True");
            conn = new SqlConnection("Data Source=JR163\\SQLEXPRESS;Initial Catalog=QLVT_test;Integrated Security=True");
            //conn = new SqlConnection();
        //    TestRegister();
        }

        void TestRegister()
        {
            var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var rk = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
            var ServerList = (String[])rk.GetValue("InstalledInstances");
            //RegistryKey key1 = cast(Registry.CurrentUser.OpenSubKey("Software\\QLVT_test").GetValue("DatabaseName"));
            //RegistryKey key2 = Registry.CurrentUser.OpenSubKey("Software\\QLVT_test").GetValue("ServerName");
            //if (key1 == null)
            //{
            //   // ConnectToDataBaseForm frm = new ConnectToDataBaseForm();
            //   // frm.ShowDialog();
               
            //}
            //else
            //{
            //    key.Close();
            //}
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
