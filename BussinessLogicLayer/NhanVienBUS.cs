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

    }
}
