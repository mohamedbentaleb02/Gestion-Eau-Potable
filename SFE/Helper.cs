using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFE
{
    public static class Helper
    {
        public static string cnnString (string cnnName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[cnnName].ConnectionString;
        }
    }
}
