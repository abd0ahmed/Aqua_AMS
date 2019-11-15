using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aqua_AMS.Database
{
   public static class ConnectionHelper
    {
#region ConnectionSet
        public static string dataString { get; set; } = Properties.Settings.Default.ConString;
        public static void setDataBase(string constring)
        {
            Properties.Settings.Default.ConString = constring;
        }
        public static SqlConnection SC()
        {

            return new SqlConnection(dataString);

        }
#endregion




    }
}
