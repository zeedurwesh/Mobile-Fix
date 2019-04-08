using System;
using System.Collections.Generic;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFix
{
     class clsDBDevice
    {
        clsDBConnection db;
        public clsDBDevice()
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
        public Int32 InsertDevice(clsDevice device)
        {
            //add the parameters
            db.AddParameter("@Manufacture", device.Manufacture);
            db.AddParameter("@Model", device.Model);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblDevice_Insert");
        }

        public Int32 UpdateDevice(clsDevice device)
        {
            //add the parameters
            db.AddParameter("@DeviceID", device.ID);
            db.AddParameter("@Manufacture", device.Manufacture);
            db.AddParameter("@Model", device.Model);

            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblDevice_Update");
        }

        public Int32 DeleteDevice(Int32 ID)
        {
            //add the parameters
            db.AddParameter("@DeviceID", ID);
           
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblDevice_Delete");
        }

        public List<clsDevice> DeviceList()
        {
                //create an array list of type lstDevices
                List<clsDevice> lstDevices = new List<clsDevice>();
                //var to store the count of records
                Int32 RecordCount;
                //var to store the index for the loop
                Int32 Index = 0;

            //get the count of records
            db.Execute("sproc_tblDevice_SelectAll");

            RecordCount = db.Count;
                //keep looking till all records are processed
                while (Index < RecordCount)
                {
                    //create a blank device
                    clsDevice device = new clsDevice();
                    //copy the data from the table to the RAM
                    device.ID = Convert.ToInt32(db.DataTable.Rows[Index]["DeviceID"]);
                    device.Manufacture = Convert.ToString(db.DataTable.Rows[Index]["Manufacture"]);
                    device.Model = Convert.ToString(db.DataTable.Rows[Index]["Model"]);
                    //add the blank page to the array list 
                    lstDevices.Add(device);
                    //increase the index
                    Index++;
                }
                //return the list as the return value of the function
                return lstDevices;

            }
    }
}