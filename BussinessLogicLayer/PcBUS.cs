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
    public class PcBUS
    {
        PcDAO dao = new PcDAO();

        public DataTable GetData1(PC obj)
        {
            return dao.GetData1(obj);
        }

        public DataTable GetData2(PC obj)
        {
            return dao.GetData2(obj);
        }

        public int Insert(PC obj)
        {
            return dao.Insert(obj);
        }
        public int Change(PC obj)
        {
            return dao.Change(obj);
        }

        public int Delete(PC obj)
        {
            return dao.Delete(obj);
        }

    }
}
