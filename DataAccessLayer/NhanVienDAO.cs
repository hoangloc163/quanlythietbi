using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ValueObject;

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

    }
}
