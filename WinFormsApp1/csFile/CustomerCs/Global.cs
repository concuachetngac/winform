using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.csFile
{
    public static class Global
    {
        static Global() { CustomerID = 1234; ContactID = 1234; }
        public static int CustomerID { get; private set; }

        public static void setCustomerID(int id)
        {
            CustomerID = id;
        }
        public static int ContactID { get; private set; }

        public static void setContactID(int id)
        {
            ContactID = id;
        }
    }
}
