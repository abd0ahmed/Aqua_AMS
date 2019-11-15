using System;

namespace Aqua_AMS.Model
{
    public interface IParentsModel
    {
        string address { get; set; }
        DateTime Date { get; set; }
        int ParentID { get; set; }
        string ParentName { get; set; }
        string Phone { get; set; }
        int UserID { get; set; }
        string ParentSSn { get; set; }
    }
}