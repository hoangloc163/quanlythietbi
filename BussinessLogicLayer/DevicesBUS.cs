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
    public class DevicesBUS
    {
        DevicesDAO dao = new DevicesDAO();

        public DataTable GetData()
        {
            return dao.GetData();
        }

        public DataTable GetDataOriginal(string SQL)
        {
            return dao.GetDataOriginal(SQL);
        }

        public DataTable GetData4Cb_Area()
        {
            return dao.GetData4Cb_Area();
        }
        public DataTable GetData4Cb_Devices()
        {
            return dao.GetData4Cb_Devices();
        }
        public DataTable GetData4Cb_Devices_By_Area(Devices obj)
        {
            return dao.GetData4Cb_Devices_By_Area(obj);
        }
        public DataTable GetData4Cb_Brand_By_Area(Devices obj)
        {
            return dao.GetData4Cb_Brand_By_Area(obj);
        }
        public DataTable GetData4Cb_Brand_By_Dtype(Devices obj)
        {
            return dao.GetData4Cb_Brand_By_Dtype(obj);
        }
        public DataTable GetData4Cb_Brand()
        {
            return dao.GetData4Cb_Brand();
        }
        public DataTable GetData4Cb_Supplier_By_Area(Devices obj)
        {
            return dao.GetData4Cb_Supplier_By_Area(obj);
        }
        public DataTable GetData4Cb_Supplier_By_Dtype(Devices obj)
        {
            return dao.GetData4Cb_Supplier_By_Dtype(obj);
        }
        public DataTable GetData4Cb_Supplier()
        {
            return dao.GetData4Cb_Supplier();
        }
        public DataTable GetData4Cb_Position()
        {
            return dao.GetData4Cb_Position();
        }
        public DataTable GetData4Cb_Position_By_Area(Devices obj)
        {
            return dao.GetData4Cb_Position_By_Area(obj);
        }
        public DataTable GetData4Cb_Status()
        {
            return dao.GetData4Cb_Status();
        }

        public string Insert_Form(Devices obj, string mess)
        {
            return dao.Insert_Form(obj, mess);
        }

        public int Change(string ChangedValue)
        {
            return dao.Change(ChangedValue);
        }

        public int Delete(Devices obj)
        {
            return dao.Delete(obj);
        }

        public string connect(bool checklocalDB, string sername, string databasename,string username, string password, string message)
        {
            return dao.Connect(checklocalDB, sername, databasename, username, password, message);
        }
    }
}
