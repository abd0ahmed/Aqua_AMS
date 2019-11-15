using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_AMS.Model
{
   public static class ModelFactory
    {
        public static IStudentModel CreateStudent()
        {
            return new StudentModel();
        }
        public static IShiftModel CreateShift()
        {
            return new ShiftModel();
        }
        public static IClassModel CreateClass()
        {
            return new ClassModel();
        }
        public static IParentsModel CreateParent()
        {
            return new ParentsModel();
        }
        public static IGradesModel Creategrade()
        {
            return new GradesModel();
        }
        public static IUserModel CreateUser()
        {
            return new UserModel();
        }
    }
}
