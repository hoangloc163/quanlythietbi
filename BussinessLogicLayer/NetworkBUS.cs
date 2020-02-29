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
    public class NetworkBUS
    {
        NetworkDAO dao = new NetworkDAO();

        public DataTable GetData()
        {
            return dao.GetData();
        }
    }
}
