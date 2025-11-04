using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_and_Crop_Sales_Record_System
{
    internal class DbConfig
    {
        public static string ConnectionString { get; } =
        @"Server=GANBADESKTOP\SQLEXPRESS;Database=HCSRSdb;Trusted_Connection=True;";
    }
}
