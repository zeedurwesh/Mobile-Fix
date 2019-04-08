using System;
using System.Collections.Generic;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFix
{
     class clsDBRepair
    {
        clsDBConnection db;
        public clsDBRepair()
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
        public Int32 InsertRepair(clsRepair repair)
        {
            //add the parameters
            db.AddParameter("@CustomerName", repair.CustomerName);
            db.AddParameter("@CustomerPhoneNo", repair.CustomerPhoneNo);
            db.AddParameter("@Date", repair.Date);
            db.AddParameter("@PhoneModel", repair.PhoneModel);
            db.AddParameter("@SerialNo_IMEI", repair.SerialNo_IMEI);
            db.AddParameter("@Fault", repair.Fault);
            db.AddParameter("@Password", repair.Password);
            db.AddParameter("@Cost", repair.Cost);
            db.AddParameter("@Deposit", repair.Deposit);
            db.AddParameter("@Balance", repair.Balance);
            db.AddParameter("@CollectionDate", repair.CollectionDate);
            db.AddParameter("@Comment", repair.Comment);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblRepair_Insert");
        }

        public Int32 UpdateRepair(clsRepair repair)
        {
            //add the parameters
            db.AddParameter("@CustomerName", repair.CustomerName);
            db.AddParameter("@CustomerPhoneNo", repair.CustomerPhoneNo);
            db.AddParameter("@Date", repair.Date);
            db.AddParameter("@PhoneModel", repair.PhoneModel);
            db.AddParameter("@SerialNo_IMEI", repair.SerialNo_IMEI);
            db.AddParameter("@Fault", repair.Fault);
            db.AddParameter("@Password", repair.Password);
            db.AddParameter("@Cost", repair.Cost);
            db.AddParameter("@Deposit", repair.Deposit);
            db.AddParameter("@Balance", repair.Balance);
            db.AddParameter("@CollectionDate", repair.CollectionDate);
            db.AddParameter("@Comment", repair.Comment);
            db.AddParameter("@RepairID", repair.ID);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblRepair_Update");
        }

        public Int32 DeleteRepair(Int32 ID)
        {
            //add the parameters
            db.AddParameter("@RepairID", ID);
           
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblRepair_Delete");
        }

        public List<clsRepair> RepairList()
        {
                //create an array list of type lstRepairs
                List<clsRepair> lstRepairs = new List<clsRepair>();
                //var to store the count of records
                Int32 RecordCount;
                //var to store the index for the loop
                Int32 Index = 0;

            //get the count of records
            db.Execute("sproc_tblRepair_SelectAll");

            RecordCount = db.Count;
                //keep looking till all records are processed
                while (Index < RecordCount)
                {
                    //create a blank repair
                    clsRepair repair = new clsRepair();
                //copy the data from the table to the RAM
                    repair.ID = Convert.ToInt32(db.DataTable.Rows[Index]["RepairID"]);
                    repair.CustomerName = Convert.ToString(db.DataTable.Rows[Index]["CustomerName"]);
                    repair.CustomerPhoneNo = Convert.ToString(db.DataTable.Rows[Index]["CustomerPhoneNo"]);
                    repair.Date = Convert.ToDateTime(db.DataTable.Rows[Index]["Date"]);
                    repair.PhoneModel = Convert.ToString(db.DataTable.Rows[Index]["PhoneModel"]);
                    repair.SerialNo_IMEI = Convert.ToString(db.DataTable.Rows[Index]["SerialNo_IMEI"]);
                    repair.Fault = Convert.ToString(db.DataTable.Rows[Index]["Fault"]);
                    repair.Password= Convert.ToString(db.DataTable.Rows[Index]["Password"]);
                    repair.Cost = Convert.ToDecimal(db.DataTable.Rows[Index]["Cost"]);
                    repair.Deposit = Convert.ToDecimal(db.DataTable.Rows[Index]["Deposit"]);
                    repair.Balance = Convert.ToDecimal(db.DataTable.Rows[Index]["Balance"]);
                    repair.CollectionDate = Convert.ToDateTime(db.DataTable.Rows[Index]["CollectionDate"]);
                repair.Comment = Convert.ToString(db.DataTable.Rows[Index]["Comment"]);
                //add the blank page to the array list 
                lstRepairs.Add(repair);
                    //increase the index
                    Index++;
                }
                //return the list as the return value of the function
                return lstRepairs;

            }
    }
}