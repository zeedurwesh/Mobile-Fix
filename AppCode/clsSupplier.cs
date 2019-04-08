using System;

namespace MobileFixVS2015
{
    public class clsSupplier
    {
        public Int32 ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public string ContactName { get; set; }

        public string ContactNumber { get; set; }
        
        public Boolean  isNameValid(string name)
        {
            Boolean isValid = true;
            if (name == null)
            {
                isValid = false;
            }else
            {
                if (name == "")
                {
                    isValid = false;
                }
                if (name.Length > 35)
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}