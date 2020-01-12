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
    public class PcDAO
    {
        dbConnect db = new dbConnect(); // code ket noi db

        public DataTable GetData1(PC obj)  // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("PC_SelectOn_DEVICES", para);
        }

        public DataTable GetData2(PC obj) // truyen 1 tham so vao lay nguyen bang 
        {
            SqlParameter[] para =
            {
                new SqlParameter("area", obj.area),
            };
            return db.GetData("PC_SelectAll", para);
        }

        public int Insert(PC obj)
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
                new SqlParameter("memory", obj.memory),
                new SqlParameter("hdd", obj.hdd),
            };
            return db.ExecuteSQL("PC_Insert", para);
        }

        public int Change(PC obj)
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
                new SqlParameter("memory", obj.memory),
                new SqlParameter("hdd", obj.hdd),
            };
            return db.ExecuteSQL("PC_Change", para);
        }

        public int Delete(PC obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("serial", obj.serial)
            };
            return db.ExecuteSQL("PC_Withdraw_Devices", para);
        }
    }
}
