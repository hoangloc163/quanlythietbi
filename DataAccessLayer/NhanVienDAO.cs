using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;
using System.Security.Cryptography;


namespace DataAccessLayer
{
    public class NhanVienDAO
    {
        dbConnect db = new dbConnect();

        public string LogIn(NhanVien obj, string check)
        {
            SqlParameter[] para =
            {
                new SqlParameter("tendangnhap", obj.tendangnhap),
                new SqlParameter("matkhau", obj.matkhau),
            };
            return db.ExecuteSQL1("NhanVien_DangNhap", para, check);
        }

        public string Mahoa(NhanVien obj)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(obj.matkhau.ToString());
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            obj.matkhau = hasPass;
            return obj.matkhau;
        }

        public DataTable GetData()
        {
            return db.GetData("NhanVien_SelectAll", null);
        }

        public string ResetPass(NhanVien obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien),
                new SqlParameter("matkhau",obj.matkhau),
            };
            return db.ExecuteSQL3("NhanVien_ResetPassword", para, mess);
        }

        public string Add(NhanVien obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien),
                new SqlParameter("matkhau",obj.matkhau),
                new SqlParameter("tennhanvien",obj.tennhanvien),
                new SqlParameter("tendangnhap",obj.tendangnhap),
                new SqlParameter("phongban",obj.phongban),
                new SqlParameter("permission",obj.permission),
            }; 
            return db.ExecuteSQL3("NhanVien_ADD", para, mess);
        }

        public string Delete(NhanVien obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien),
            };
            return db.ExecuteSQL3("NhanVien_Delete", para, mess);
        }
    }
}
