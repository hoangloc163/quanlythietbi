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
    public class MoDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData1(MO obj)  // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("MO_SelectOn_DEVICES", para);
        }

        public DataTable GetData2(MO obj) // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("MO_SelectAll", para);
        }

        public int Insert(MO obj)
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
                new SqlParameter("position",obj.position),
            };
            return db.ExecuteSQL("MO_Insert", para);
        }

        public int Change(MO obj)
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
                new SqlParameter("position",obj.position),
            };
            return db.ExecuteSQL("MO_Change", para);
        }

        public int Delete(MO obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial", obj.serial)
            };
            return db.ExecuteSQL("MO_Withdraw_Devices", para);
        }
    }
}
