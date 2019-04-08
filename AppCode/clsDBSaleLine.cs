using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFixVS2015.AppCode
{
    class clsDBSaleLine
    {
        clsDBConnection db;
        public clsDBSaleLine()
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


        public int AddSaleLine(Int32 SaleID, Int32 ProductID,  double Price, string Notes)
        {
            clsDBConnection db = new clsDBConnection();
            //add the parameters
            db.AddParameter("@saleID", SaleID);
            //add the parameters
            db.AddParameter("@productID", ProductID);
            //add the parameters
            db.AddParameter("@price", Price);
            //add the parameters
            db.AddParameter("@notes", Notes);
            //execute the stored procedure
            int Result = db.Execute("AddSaleLineProcedure");

            
            return Result;

        }
    }
}
