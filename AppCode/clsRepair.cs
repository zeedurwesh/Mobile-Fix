using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFixVS2015
{
    public class clsRepair
    {
        public Int32 ID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhoneNo { get; set; }

        public DateTime Date { get; set; }

        public string PhoneModel { get; set; }

        public string SerialNo_IMEI { get; set; }

        public string Fault { get; set; }

        public string Password { get; set; }

        public decimal Cost { get; set; }

        public decimal Deposit { get; set; }

        public decimal Balance { get; set; }

        public DateTime CollectionDate { get; set; }

        public string Comment { get; set; }
    }
}
