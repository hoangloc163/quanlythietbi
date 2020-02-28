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
    public class ServerBUS
    {
        ServerDAO dao = new ServerDAO();

        //public DataTable GetData()
        //{
        //    return dao.GetData();
        //}

        public DataTable GetData4Cb_Brand()
        {
            return dao.GetData4Cb_Brand();
        }
        public DataTable GetData4Cb_Supplier()
        {
            return dao.GetData4Cb_Supplier();
        }
        public DataTable GetData4Cb_Status()
        {
            return dao.GetData4Cb_Status();
        }
        public DataTable GetData4Cb_Warranty()
        {
            return dao.GetData4Cb_Warranty();
        }

        public DataTable GetData_Serverdtgv_By_Area(Server obj)
        {
            return dao.GetData_Serverdtgv_By_Area(obj);
        }
        public string Insert(Server obj, string mess)
        {
            return dao.Insert(obj, mess);
        }

        public int Change(string ChangedValue)
        {
            return dao.Change(ChangedValue);
        }

        public string ChangeALot(Server obj, string mess)
        {
            return dao.ChangeALot(obj, mess);
        }

        public int Delete(Server obj)
        {
            return dao.Delete(obj);
        }

    }
}
