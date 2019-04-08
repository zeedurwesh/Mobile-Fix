using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFixVS2015.AppCode
{
    class claDBSale
    {
        clsDBConnection db;
        public claDBSale()
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


        public int AddSale(DateTime Date, string PaymentMethod, double TotalAmount )
        {
            //add the parameters
            db.AddParameter("@date", Date.ToString("yyyyMMdd"));
            //add the parameters
            db.AddParameter("@paymentmethod", PaymentMethod);
            //add the parameters
            db.AddParameter("@TotalAmount", TotalAmount);
            //execute the stored procedure
            db.Execute("AddSaleProcedure");
            int PK = 0;
            int Index = 0;
            while (Index < db.Count)
            {
                //copy the data from the table to the RAM
                PK = Convert.ToInt32(db.DataTable.Rows[Index]["SaleId"]);

                Index++;
            }
            //return the Primary Key as the return value of the function
            return PK;

        }
    }
}
