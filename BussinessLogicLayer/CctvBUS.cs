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
    public class CctvBUS
    {
        CctvDAO dao = new CctvDAO();

        public DataTable GetData1(CCTV obj)
        {
            return dao.GetData1(obj);
        }

        public DataTable GetData2(CCTV obj)
        {
            return dao.GetData2(obj);
        }

        public int Insert(CCTV obj)
        {
            return dao.Insert(obj);
        }
        public int Change(CCTV obj)
        {
            return dao.Change(obj);
        }

        public int Delete(CCTV obj)
        {
            return dao.Delete(obj);
        }
    }
}
