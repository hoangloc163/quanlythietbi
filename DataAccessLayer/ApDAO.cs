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
    public class ApDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData1(AP obj)  // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("AP_SelectOn_DEVICES", para);
        }

        public DataTable GetData2(AP obj) // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("AP_SelectAll", para);
        }

        public int Insert(AP obj)
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
                new SqlParameter("log_name", obj.login_name),
                new SqlParameter("password",obj.passwrd),
            };
            return db.ExecuteSQL("AP_Insert", para);
        }

        public int Change(AP obj)
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
                new SqlParameter("log_name", obj.login_name),
                new SqlParameter("password",obj.passwrd),
            };
            return db.ExecuteSQL("AP_Change", para);
        }

        public int Delete(AP obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial", obj.serial)
            };
            return db.ExecuteSQL("AP_Withdraw_Devices", para);
        }
    }
}
