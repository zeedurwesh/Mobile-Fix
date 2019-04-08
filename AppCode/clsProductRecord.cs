using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileFixVS2015
{
    public class clsProductRecord
    {
        public Int32 ID { get; set; }

        public string SerialNo_IMEI { get; set; }

        public Int32 SupplierId { get; set; }

        public string SupplierName { get; set; }

        public Int32 DeviceId { get; set; }

        public string DeviceModel { get; set; }

        public decimal Price { get; set; }

        public DateTime DateBought { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public Boolean Returned { get; set; }
    }
}

