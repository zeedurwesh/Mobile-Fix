using System;
using System.Collections.Generic;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFix
{
     class clsDBSupplier
    {
        clsDBConnection db;
        public clsDBSupplier()
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
        public Int32 InsertSupplier(clsSupplier supplier)
        {
            //add the parameters
            db.AddParameter("@SupplierName", supplier.Name);
            db.AddParameter("@Address", supplier.Address);
            db.AddParameter("@Town", supplier.Town);
            db.AddParameter("@Postcode", supplier.Postcode);
            db.AddParameter("@ContactName", supplier.ContactName);
            db.AddParameter("@ContactNumber", supplier.ContactNumber);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblSupplier_Insert");
        }

        public Int32 UpdateSupplier(clsSupplier supplier)
        {
            //add the parameters
            db.AddParameter("@SupplierID", supplier.ID);
            db.AddParameter("@SupplierName", supplier.Name);
            db.AddParameter("@Address", supplier.Address);
            db.AddParameter("@Town", supplier.Town);
            db.AddParameter("@Postcode", supplier.Postcode);
            db.AddParameter("@ContactName", supplier.ContactName);
            db.AddParameter("@ContactNumber", supplier.ContactNumber);
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblSupplier_Update");
        }

        public Int32 DeleteSupplier(Int32 ID)
        {
            //add the parameters
            db.AddParameter("@SupplierID", ID);
           
            //execute the stored procedure returning the primary key value of the new record
            return db.Execute("sproc_tblSupplier_Delete");
        }

        public List<clsSupplier> SupplierList()
        {
                //create an array list of type lstSuppliers
                List<clsSupplier> lstSuppliers = new List<clsSupplier>();
                //var to store the count of records
                Int32 RecordCount;
                //var to store the index for the loop
                Int32 Index = 0;

            //get the count of records
            db.Execute("sproc_tblSupplier_SelectAll");

            RecordCount = db.Count;
                //keep looking till all records are processed
                while (Index < RecordCount)
                {
                    //create a blank supplier
                    clsSupplier supplier = new clsSupplier();
                    //copy the data from the table to the RAM
                    supplier.ID = Convert.ToInt32(db.DataTable.Rows[Index]["SupplierID"]);
                    supplier.Name = Convert.ToString(db.DataTable.Rows[Index]["SupplierName"]);
                    supplier.Address = Convert.ToString(db.DataTable.Rows[Index]["Address"]);
                    supplier.Town = Convert.ToString(db.DataTable.Rows[Index]["Town"]);
                    supplier.Postcode = Convert.ToString(db.DataTable.Rows[Index]["PostCode"]);
                    supplier.ContactName = Convert.ToString(db.DataTable.Rows[Index]["ContactName"]);
                    supplier.ContactNumber = Convert.ToString(db.DataTable.Rows[Index]["ContactNumber"]);
                    //add the blank page to the array list 
                    lstSuppliers.Add(supplier);
                    //increase the index
                    Index++;
                }
                //return the list as the return value of the function
                return lstSuppliers;

            }
    

    }
}