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
    public class CctvDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData1(CCTV obj)  // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("CCTV_SelectOn_DEVICES", para);
        }

        public DataTable GetData2(CCTV obj) // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("CCTV_SelectAll", para);
        }

        public int Insert(CCTV obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("area",obj.area),
                new SqlParameter("devices",obj.devices),
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
                new SqlParameter("username",obj.username),
                new SqlParameter("ip_addr",obj.ip_addr),
                new SqlParameter("dns", obj.dns),
                new SqlParameter("defaultgw",obj.defaultgw),
            };
            return db.ExecuteSQL("CCTV_Insert", para);
        }

        public int Change(CCTV obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("area",obj.area),
                new SqlParameter("devices",obj.devices),
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
                new SqlParameter("username",obj.username),
                new SqlParameter("ip_addr",obj.ip_addr),
                new SqlParameter("dns", obj.dns),
                new SqlParameter("defaultgw",obj.defaultgw),
            };
            return db.ExecuteSQL("CCTV_Change", para);
        }

        public int Delete(CCTV obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial", obj.serial)
            };
            return db.ExecuteSQL("CCTV_Withdraw_Devices", para);
        }
    }
}
