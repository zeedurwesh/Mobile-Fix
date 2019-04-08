using System;
using System.Collections.Generic;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFix
{
     class clsDBProductRecord
    {
        clsDBConnection db;
        public clsDBProductRecord()
        {
            db = new clsDBConnection();
        }

        public Int32 Count
        {
            get
            {
                return db.Count;

            }
        }
        public Int32 InsertProductRecord(clsProductRecord productRecord)
        {
            //add the parameters
            db.AddParameter("@SerialNo_IMEI", productRecord.SerialNo_IMEI);
            db.AddParameter("@SupplierId", productRecord.SupplierId);
            db.AddParameter("@DeviceId", productRecord.DeviceId);
            db.AddParameter("@Price", productRecord.Price);
            db.AddParameter("@DateBought", productRecord.DateBought);
            db.AddParameter("@Description", productRecord.Description);
            //db.AddParameter("@Status", productRecord.Status);
            db.AddParameter("@Returned", productRecord.Returned);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblProductRecord_Insert");
        }

        public Int32 UpdateProductRecord(clsProductRecord productRecord)
        {
            //add the parameters
            db.AddParameter("@ProductId", productRecord.ID);
            db.AddParameter("@SerialNo_IMEI", productRecord.SerialNo_IMEI);
            db.AddParameter("@SupplierId", productRecord.SupplierId);
            db.AddParameter("@DeviceId", productRecord.DeviceId);
            db.AddParameter("@Price", productRecord.Price);
            db.AddParameter("@DateBought", productRecord.DateBought);
            db.AddParameter("@Description", productRecord.Description);
            db.AddParameter("@Status", productRecord.Status);
            db.AddParameter("@Returned", productRecord.Returned);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblProductRecord_Update");
        }

        public Int32 DeleteProductRecord(Int32 ID)
        {
            //add the parameters
            db.AddParameter("@ProductRecordID", ID);
           
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblProductRecord_Delete");
        }

        public List<clsProductRecord> ProductRecordList()
        {
                //create an array list of type lstProductRecords
                List<clsProductRecord> lstProductRecords = new List<clsProductRecord>();
                //var to store the count of records
                Int32 RecordCount;
                //var to store the index for the loop
                Int32 Index = 0;

            //get the count of records
            db.Execute("sproc_tblProductRecord_SelectAll");

            RecordCount = db.Count;
                //keep looking till all records are processed
                while (Index < RecordCount)
                {
                    //create a blank productRecord
                    clsProductRecord productRecord = new clsProductRecord();
                    //copy the data from the table to the RAM
                    productRecord.ID = Convert.ToInt32(db.DataTable.Rows[Index]["ProductId"]);
                    productRecord.SerialNo_IMEI = Convert.ToString(db.DataTable.Rows[Index]["SerialNo_IMEI"]);
                    productRecord.SupplierId = Convert.ToInt32(db.DataTable.Rows[Index]["SupplierId"]);
                    productRecord.SupplierName = Convert.ToString(db.DataTable.Rows[Index]["SupplierName"]);
                    productRecord.DeviceId = Convert.ToInt32(db.DataTable.Rows[Index]["DeviceId"]);
                    productRecord.DeviceModel = Convert.ToString(db.DataTable.Rows[Index]["Model"]);
                    productRecord.Price = Convert.ToDecimal(db.DataTable.Rows[Index]["Price"]);
                    productRecord.DateBought = Convert.ToDateTime(db.DataTable.Rows[Index]["DateBought"]);
                    productRecord.Description = Convert.ToString(db.DataTable.Rows[Index]["Description"]);
                    productRecord.Status = Convert.ToString(db.DataTable.Rows[Index]["Status"]);
                    productRecord.Returned = Convert.ToBoolean(db.DataTable.Rows[Index]["Returned"]);
                //add the blank page to the array list 
                lstProductRecords.Add(productRecord);
                    //increase the index
                    Index++;
                }
                //return the list as the return value of the function
                return lstProductRecords;

            }
    }
}