using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_AMS.Model
{
  public class StudentModel : IStudentModel
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentGrid { get; set; }
        public int StudentClass { get; set; }
        public int ParentID { get; set; }
        public DateTime dataAdded { get; set; }
        public DateTime DOP { get; set; }
        public int ShiftID { get; set; }
        public int UserID { get; set; }

    }
}
