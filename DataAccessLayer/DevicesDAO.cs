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
    public class DevicesDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData()
        {
            return db.GetData("DEVICES_SelectAll", null);
        }

        public DataTable GetDataOriginal(string SqlQuery)
        {
            return db.GetDataOriginal(SqlQuery);
        }

        public DataTable GetData4Cb_Area()
        {
            return db.GetData("DEVICES_CB_Select_DArea", null);
        }
        public DataTable GetData4Cb_Devices()
        {
            return db.GetData("DEVICES_CB_Select_Dtype", null);
        }
        
        public DataTable GetData4Cb_Brand()
        {
            return db.GetData("DEVICES_CB_Select_Brand", null);
        }
        public DataTable GetData4Cb_Supplier()
        {
            return db.GetData("DEVICES_CB_Select_Supplier", null);
        }
        public DataTable GetData4Cb_Position()
        {
            return db.GetData("DEVICES_CB_Select_Position", null);
        }
        public DataTable GetData4Cb_Status()
        {
            return db.GetData("DEVICES_CB_Select_Status", null);
        }


        public int Insert(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea),
                new SqlParameter("dtype",obj.dtype),
                new SqlParameter("hostname", obj.hostname),
                new SqlParameter("brand", obj.brand),
                new SqlParameter("model", obj.model),
                new SqlParameter("serial", obj.serial),
                new SqlParameter("invoice_date", obj.invoice_date),
                new SqlParameter("handover_date", obj.handover_date),
                new SqlParameter("warranty", obj.warranty),
                new SqlParameter("supplies", obj.supplies),
                new SqlParameter("remark", obj.remark),
                new SqlParameter("location",obj.location),
                new SqlParameter("assetcode", obj.assetcode),
                new SqlParameter("usrname",obj.usrname),
                new SqlParameter("position",obj.position),
                new SqlParameter("memory", obj.memory),
                new SqlParameter("hdd", obj.hdd),
                new SqlParameter("dstatus",obj.dstatus),
                new SqlParameter("log_name",obj.log_name),
                new SqlParameter("passwrd", obj.passwrd),
                new SqlParameter("dns", obj.dns),
                new SqlParameter("default_gw", obj.default_gw),
                new SqlParameter("ip_addr", obj.ip_addr),
                new SqlParameter("mac_addr", obj.mac_addr),
            };
            return db.ExecuteSQL("Devices_Insert", para);
        }

        public string Insert_Form(Devices obj, string mess)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea),
                new SqlParameter("dtype",obj.dtype),
                new SqlParameter("brand", obj.brand),
                new SqlParameter("model", obj.model),
                new SqlParameter("serial", obj.serial),
                new SqlParameter("invoice_date", obj.invoice_date),
                new SqlParameter("handover_date", obj.handover_date),
                new SqlParameter("warranty", obj.warranty),
                new SqlParameter("supplies", obj.supplies),
                new SqlParameter("remark", obj.remark),
                new SqlParameter("dstatus",obj.dstatus),
                new SqlParameter("mac_addr", obj.mac_addr),
            };
            return db.ExecuteSQL3("Devices_Insert_Form", para, mess);
        }

      
        public int Change(string ChangedValue)
        {
            return db.ExecuteSQL(ChangedValue);
        }

        public int Delete(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial",obj.serial),
            };
            return db.ExecuteSQL("Devices_Delete", para);
        }

        public string Connect(string sername, string databasename, string message)
        {
            return db.Connect2DB(sername, databasename, message);
        }
    }
}
