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
    public class ServerDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData4Cb_Brand()
        {
            return db.GetData("SERVER_CB_Select_Brand", null);
        }
        public DataTable GetData4Cb_Supplier()
        {
            return db.GetData("SERVER_CB_Select_Supplier", null);
        }
        public DataTable GetData4Cb_Status()
        {
            return db.GetData("SERVER_CB_Select_Status", null);
        }
        public DataTable GetData4Cb_Warranty()
        {
            return db.GetData("SERVER_CB_Select_Warranty", null);
        }

        public DataTable GetData_Serverdtgv_By_Area(Server obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea)
            };
            return db.GetData("SERVER_Select_Area", para);
        }

        public string Insert(Server obj, string mess)
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
                new SqlParameter("supplies", obj.supplier),
                new SqlParameter("remarks", obj.remarks),
                new SqlParameter("dstatus",obj.dstatus),
                new SqlParameter("location", obj.location),
                new SqlParameter("CPU",obj.CPU),
                new SqlParameter("RAM", obj.RAM),
                new SqlParameter("power_supply", obj.power_supply),
                new SqlParameter("storage", obj.storage),
                new SqlParameter("raid_controller", obj.raid_controller),
                new SqlParameter("graphic",obj.graphic),
                new SqlParameter("ethernet", obj.ethernet),
                new SqlParameter("optical_drive",obj.optical_drive),
                new SqlParameter("hostname",obj.hostname),
                new SqlParameter("assetcode",obj.assetcode),
            };
            return db.ExecuteSQL3("SERVER_Insert", para, mess);
        }

        public int Change(string ChangedValue)
        {
            return db.ExecuteSQL(ChangedValue);
        }

        public string ChangeALot(Server obj, string mess)
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
                new SqlParameter("supplies", obj.supplier),
                new SqlParameter("remarks", obj.remarks),
                new SqlParameter("dstatus",obj.dstatus),
                new SqlParameter("location", obj.location),
                new SqlParameter("CPU",obj.CPU),
                new SqlParameter("RAM", obj.RAM),
                new SqlParameter("power_supply", obj.power_supply),
                new SqlParameter("storage", obj.storage),
                new SqlParameter("raid_controller", obj.raid_controller),
                new SqlParameter("graphic",obj.graphic),
                new SqlParameter("ethernet", obj.ethernet),
                new SqlParameter("optical_drive",obj.optical_drive),
                new SqlParameter("hostname",obj.hostname),
                new SqlParameter("assetcode",obj.assetcode),
            };
            return db.ExecuteSQL3("SERVER_update", para, mess);
        }

        public int Delete(Server obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial",obj.serial),
            };
            return db.ExecuteSQL("SERVER_Delete", para);
        }
    }
}
