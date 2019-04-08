using System;
using System.Collections.Generic;
using MobileFixVS2015;
using MobileFixVS2015.AppCode;

namespace MobileFixVS2015
{
    class clsDBLogin
    {
        clsDBConnection db;
        public clsDBLogin()
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

        public Int32 CheckUser(clsLogin user)
        {
            //add the parameters
            db.AddParameter("@UserName", user.UserName);
            db.AddParameter("@Password", user.Password);
            //execute the stored procedure
            return db.Execute("sproc_tblUsers_SelectAll");
        }


        public Int32 AddUser(clsLogin user)
        {
            //add the parameters
            db.AddParameter("@UserName", user.UserName);
            db.AddParameter("@Password", user.Password);
            //execute the stored procedure
            return db.Execute("sproc_tblUsers_Insert");
        }

    }
}
