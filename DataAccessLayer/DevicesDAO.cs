﻿using System;
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
        public DataTable GetData4Cb_Devices_By_Area(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea)
            };
            return db.GetData("DEVICES_CB_Select_Dtype_By_Area", para);
        }

        public DataTable GetData4Cb_Brand_By_Area(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea)
            };
            return db.GetData("DEVICES_CB_Select_Brand_By_Area", para);
        }

        public DataTable GetData4Cb_Brand_By_Dtype(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("dtype",obj.dtype)
            };
            return db.GetData("DEVICES_CB_Select_Brand_By_Dtype", para);
        }

        public DataTable GetData4Cb_Brand()
        {
            return db.GetData("DEVICES_CB_Select_Brand", null);
        }
        public DataTable GetData4Cb_Supplier_By_Area(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("darea",obj.darea)
            };
            return db.GetData("DEVICES_CB_Select_Supplier_By_Area", para);
        }
        public DataTable GetData4Cb_Supplier_By_Dtype(Devices obj)
        {
            SqlParameter[] para =
            {
                new SqlParameter("dtype",obj.dtype)
            };
            return db.GetData("DEVICES_CB_Select_Supplier_By_Dtype", para);
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
                new SqlParameter("remark", obj.remarks),
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

        public string Connect(bool checklocalDB, string sername, string databasename, string username, string password, string message)
        {
            return db.Connect2DB(checklocalDB, sername, databasename, username, password, message);
        }
    }
}
