using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua_AMS.Model;
using Dapper;

namespace Aqua_AMS.Database
{
  public static class DataAccess
    {
#region SetConnection
        private static string connectionString = ConnectionHelper.dataString;
        public static string ConnectionString { get => connectionString; private set => connectionString = value; }

        public static SqlConnection SC()
        {

            return new SqlConnection(connectionString);

        }

        #endregion
        #region Parents
        public static void InsertParent(IParentsModel model)
        {

            using (var connection = SC())
            {
                DynamicParameters Dp = new DynamicParameters();
               




            }


        }




        #endregion








    }
}
