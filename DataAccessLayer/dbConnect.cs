using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using ValueObject;

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
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Asset Management");
            if (key != null) 
            {
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                var rk = localMachine.OpenSubKey("SOFTWARE\\Asset Management");
               
                var DataBaseName = rk.GetValue("DatabaseName");
                var ComputerName = rk.GetValue("ComputerName");

                var Encrypt_Key = "b14ca5898a4e4133bbce2ea2315a1916"; // key giai ma doi xung
                var UserNameEncrytped = Convert.ToString(rk.GetValue("UserName"));
                var UserName_decryptedString = EncryptSymectricKey_AesOperation.DecryptString(Encrypt_Key, UserNameEncrytped);
                var UserName = UserName_decryptedString;

                var PasswordsEncrytped = Convert.ToString(rk.GetValue("Passwords"));
                var Passwords_decryptedString = EncryptSymectricKey_AesOperation.DecryptString(Encrypt_Key, PasswordsEncrytped);
                var Passwords = Passwords_decryptedString;

                var ServerSQLEncrytped = Convert.ToString(rk.GetValue("ServerName"));
                var ServerSQL_decryptedString = EncryptSymectricKey_AesOperation.DecryptString(Encrypt_Key, ServerSQLEncrytped);
                var ServerSQL = ServerSQL_decryptedString;

                var CheckLocal = rk.GetValue("LocalCheck");
                conn = new SqlConnection("Data Source=" + ServerSQL.ToString() + ";Initial Catalog=" + DataBaseName.ToString() +";Persist Security Info=True;User ID=" + UserName + ";Password=" + Passwords+";Integrated Security=" + CheckLocal + "");
            }
        }

        public string Connect2DB(bool checklocalDB, string sername, string DatabaseName,string UserName, string Passwords, string message)
        {
            try
            {
                if (checklocalDB != true)
                {
                    ConnectString = "Data Source=" + sername + ";Network Library=DBMSSOCN; Initial Catalog=" + DatabaseName + "; User ID=" + UserName + "; Password=" + Passwords;// + ";Integrated Security=True";
                }
                else
                {
                    ConnectString = "Data Source=" + sername + "; Initial Catalog=" + DatabaseName + ";Persist Security Info=True; User ID=" + UserName + "; Password=" + Passwords + ";Integrated Security=" + checklocalDB + "";
                }


                conn = new SqlConnection(ConnectString);
                conn.Open();

                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Asset Management");
                // ma hoa & luu servername trong regedit
                var Encrypt_Key = "b14ca5898a4e4133bbce2ea2315a1916"; // key "ma hoa" & "giai ma" doi xung              
                var Sername_Encrypt = sername.ToString();
                var Servername_encryptedString = EncryptSymectricKey_AesOperation.EncryptString(Encrypt_Key, Sername_Encrypt);
                key.SetValue("ServerName", Servername_encryptedString);
                // khong ma hoa databasename trong regedit
                key.SetValue("DatabaseName", DatabaseName);
                // ma hoa & luu username trong regedit
                var UserName_Encrypt = UserName.ToString();
                var UserName_encryptedString = EncryptSymectricKey_AesOperation.EncryptString(Encrypt_Key, UserName_Encrypt);
                key.SetValue("UserName", UserName_encryptedString);
                // ma hoa & luu passwords trong regedit
                var Passwords_Encrypt = Passwords.ToString();
                var Passwords_encryptedPasswords = EncryptSymectricKey_AesOperation.EncryptString(Encrypt_Key, Passwords_Encrypt);
                key.SetValue("Passwords", Passwords_encryptedPasswords);
                //key.SetValue("ComputerName", sername.Substring(0, sername.IndexOf("\\")));         

                if (checklocalDB != true)
                {
                    key.SetValue("LocalCheck", "false");
                }
                else
                {
                    key.SetValue("LocalCheck", "True");
                }
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
