using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua_AMS.Model;
using System.Data;
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
        public static int InsertParent(IParentsModel model)
        {

            using (var connection = SC())
            {
                DynamicParameters Dp = new DynamicParameters();
                Dp.Add("@ParentID", model.ParentID, direction: ParameterDirection.Output);
                Dp.Add("@Name", model.ParentName);
                Dp.Add("@Address", model.address);
                Dp.Add("@SSN", model.ParentSSn);
                Dp.Add("@Phone", model.Phone);
                connection.ExecuteScalar("I_Parent", Dp, commandType: CommandType.StoredProcedure);
                return Dp.Get<int>("ParentID");
            }


        }
        public static List<IParentsModel> SelectParentBySSn(string ssn)
        {
            IParentsModel model = ModelFactory.CreateParent();
            using (var connection = SC())
            {

                DynamicParameters Dp = new DynamicParameters();
                Dp.Add("SSN", ssn, DbType.String);
                var result = connection.Query<ParentsModel>("S_Parent_Ssn @SSN", new { SSN = ssn }).ToList<IParentsModel>();


                return result;

            }


        }

        public static DataTable selectAllParents()
        {
            DataTable dt = new DataTable();
            using (var connection = SC())
            {

                var result = connection.ExecuteReader("select * from Tbl_Parents");

                dt.Load(result);

            }


            return dt;
        }


        #endregion


        #region Geades
        public static List<GradesModel> SelectAllGrids()
        {

            using (var Connection = SC())
            {

                var res = Connection.Query<GradesModel>("Select * From Tbl_Grades").ToList();


                return res;
            }

        }



        #endregion

#region Classes



        public static List<ClassModel> SelectAllClasses()

        {
            using (var Connection = SC())
            {

                var res = Connection.Query<ClassModel>("Select * From Tbl_Classes").ToList();


                return res;
            }


        }

        public static DataTable selectClassesWithCount()
        {
            DataTable dt = new DataTable();

            using (var Connection = SC())
            {

                var res = Connection.ExecuteReader("S_ClassData");


                 dt.Load(res);
            }
            return dt;



        }




        #endregion


        #region Shifts


        public static List<ShiftModel> SelectAllShifts()

        {
            using (var Connection = SC())
            {
                var res = Connection.Query<ShiftModel>("Select * From Tbl_Shifts").ToList();
                return res;
            }
        }






        #endregion
        #region Students
        public static void InsertNewStudent(IStudentModel model)
        {
            using (var connection = SC())
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@StudentId", model.StudentID,DbType.Int32,ParameterDirection.Output);
                dp.Add("@StudentName", model.StudentName);
                dp.Add("@ParentId", model.ParentID);
                dp.Add("@ShiftId", model.ShiftID);
                dp.Add("@ClassId", model.StudentClass);
                dp.Add("@GradeId", model.StudentGrid);
                dp.Add("@Dop", model.DOP);

                connection.Execute("I_Student", dp, commandType: CommandType.StoredProcedure);



            }





        }





#endregion





    }
}
