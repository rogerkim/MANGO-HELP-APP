using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpMe
{
    public class SQL
    {
        public static readonly string CONSTRING = "****";

        public static readonly string SELECT_ORDER = "SELECT orderkey FROM Orders where ExternOrderKey=@orderID";

        public static readonly string UPDATE_C_Address2 = "UPDATE orders set C_Address2 = @C_Address2 where storerkey = 'MANGOKR' and ExternOrderKey=@orderID";

        public static readonly string UPDATE_C_Address3 = "UPDATE orders set C_Address3 = @C_Address3 where storerkey = 'MANGOKR' and ExternOrderKey=@orderID";

        public static readonly string SELECT_NO_TERMINAL = "SELECT ExternOrderKey, C_Address2, C_Address3 FROM Orders WHERE B_City is null  and storerkey = 'MANGOKR'";

        public static readonly string DELETE_MANGO01 = "DELETE FROM RDT. RDTMOBREC WHERE USERNAME = 'mango01' and storerkey='MANGOKR'";

        public static readonly string DELETE_MANGO02 = "DELETE FROM RDT. RDTMOBREC WHERE USERNAME = 'mango02' and storerkey='MANGOKR'";

        public static readonly string UPDATE_TRANSMITLOG2 = "update transmitlog2 set transmitflag = 0 where key3 = 'MANGOKR' and key1 = @orderKey";
    }
}