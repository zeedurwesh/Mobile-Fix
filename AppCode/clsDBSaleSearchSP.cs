using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFixVS2015.AppCode
{
    class clsDBSaleSearchSP
    {
        clsDBConnection db;
        public clsDBSaleSearchSP()
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


        public List<clsSaleSearchSP> SearchList(string SN)
        {
            //create an array list of type lstDevices
            List<clsSaleSearchSP> lstSaleSearch = new List<clsSaleSearchSP>();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;

            //add the parameters
            db.AddParameter("@SN", SN);
            //execute the stored procedure
            db.Execute("SaleSearchProcedure");

            RecordCount = db.Count;
            //keep looking till all records are processed
            while (Index < RecordCount)
            {
                //create a blank device
                clsSaleSearchSP SaleSearch = new clsSaleSearchSP();
                //copy the data from the table to the RAM
                SaleSearch.ID = Convert.ToInt32(db.DataTable.Rows[Index]["ProductId"]);
                SaleSearch.SN = Convert.ToString(db.DataTable.Rows[Index]["SerialNo_IMEI"]);
                SaleSearch.Model = Convert.ToString(db.DataTable.Rows[Index]["Model"]);
                SaleSearch.Price = Convert.ToDouble(db.DataTable.Rows[Index]["Price"]);
                SaleSearch.Returned = Convert.ToBoolean(db.DataTable.Rows[Index]["Returned"]);
                SaleSearch.DateBought = Convert.ToDateTime(db.DataTable.Rows[Index]["DateBought"]);
                //add the blank page to the array list 
                lstSaleSearch.Add(SaleSearch);
                //increase the index
                Index++;
            }
            //return the list as the return value of the function
            return lstSaleSearch;

        }
    }
}
