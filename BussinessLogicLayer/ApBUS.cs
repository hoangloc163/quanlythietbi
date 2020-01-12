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
    public class ApBUS
    {
        ApDAO dao = new ApDAO();

        public DataTable GetData1(AP obj)
        {
            return dao.GetData1(obj);
        }

        public DataTable GetData2(AP obj)
        {
            return dao.GetData2(obj);
        }

        public int Insert(AP obj)
        {
            return dao.Insert(obj);
        }
        public int Change(AP obj)
        {
            return dao.Change(obj);
        }

        public int Delete(AP obj)
        {
            return dao.Delete(obj);
        }
    }
}
