using System;

namespace Aqua_AMS.Model
{
    public interface IStudentModel
    {
        DateTime dataAdded { get; set; }
        DateTime DOP { get; set; }
        int ParentID { get; set; }
        int ShiftID { get; set; }
        int StudentClass { get; set; }
        int StudentGrid { get; set; }
        int StudentID { get; set; }
        string StudentName { get; set; }
        int UserID { get; set; }
    }
}