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
    public class NetworkDAO
    {
        dbConnect db = new dbConnect();
        public DataTable GetData()
        {
            return db.GetData("NETWORK_SelectAll", null);
        }
    }
}
