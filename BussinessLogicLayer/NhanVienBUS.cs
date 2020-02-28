using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ValueObject;
using System.Data;

namespace BussinessLogicLayer
{
    public class NhanVienBUS
    {
        NhanVienDAO dao = new NhanVienDAO();

        public string LogIn(NhanVien obj, string check)
        {
            return dao.LogIn(obj, check);
        }

        public string Mahoa(NhanVien obj)
        {
            return dao.Mahoa(obj);
        }

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public string ResetPass(NhanVien obj, string mess)
        {
            return dao.ResetPass(obj, mess);
        }

        public string Add(NhanVien obj, string mess)
        {
            return dao.Add(obj, mess);
        }

     }
}
