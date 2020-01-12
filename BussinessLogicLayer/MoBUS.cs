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
    public class MoBUS
    {
        MoDAO dao = new MoDAO();

        public DataTable GetData1(MO obj)
        {
            return dao.GetData1(obj);
        }

        public DataTable GetData2(MO obj)
        {
            return dao.GetData2(obj);
        }

        public int Insert(MO obj)
        {
            return dao.Insert(obj);
        }
        public int Change(MO obj)
        {
            return dao.Change(obj);
        }

        public int Delete(MO obj)
        {
            return dao.Delete(obj);
        }
    }
}
