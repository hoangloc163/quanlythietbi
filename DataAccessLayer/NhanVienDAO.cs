using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;
using System.Security.Cryptography;
using System.Diagnostics;
//using System.IO;


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
            return db.ExecuteSQL1("NHANVIEN_Login", para, check);
        }

        
        public string Mahoa(NhanVien obj)
        {
            //code ma hoa cu
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(obj.matkhau.ToString());
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";
            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}
            //obj.matkhau = hasPass;
            
            //encrypt new
            byte[] data_encrypt = UTF8Encoding.UTF8.GetBytes(obj.matkhau.ToString());
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(obj.matkhau.ToString()));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data_encrypt, 0, data_encrypt.Length);
                    obj.matkhau = Convert.ToBase64String(results, 0, results.Length);
                }
            }      
            // giu nguyen
            return obj.matkhau;
        }

        public string GiaiMa(NhanVien obj)
        {
            //decrypt new
            byte[] data_decrypt = Convert.FromBase64String(obj.matkhau.ToString()); // decrypt the incrypted text
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(obj.matkhau.ToString()));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data_decrypt, 0, data_decrypt.Length);
                    obj.matkhau = UTF8Encoding.UTF8.GetString(results);
                }
            }
            // giu nguyen
            return obj.matkhau;
        }

        public DataTable GetData()
        {
            return db.GetData("NHANVIEN_SelectAll", null);
        }

        public string ResetPass(NhanVien obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien),
                new SqlParameter("matkhau",obj.matkhau),
            };
            return db.ExecuteSQL3("NHANVIEN_ResetPassword", para, mess);
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
            return db.ExecuteSQL3("NHANVIEN_Add", para, mess);
        }

        public string Delete(NhanVien obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien),
            };
            return db.ExecuteSQL3("NHANVIEN_Delete", para, mess);
        }

        public string Change(NhanVien obj, string mess)
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
            return db.ExecuteSQL3("NHANVIEN_Change", para, mess);
        }

        public DataTable Search(NhanVien obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("manhanvien",obj.manhanvien)
            };
            return db.GetData("NHANVIEN_Search", para);
        }
    }
}
