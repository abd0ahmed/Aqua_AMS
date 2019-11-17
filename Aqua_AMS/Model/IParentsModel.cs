using System;

namespace Aqua_AMS.Model
{
    public interface IParentsModel
    {
        string ParentName { get; set; }
        string address { get; set; }
        DateTime Date { get; set; }
        
        
        string Phone { get; set; }
        int UserID { get; set; }
        string ParentSSn { get; set; }
        int ParentID { get; set; }
    }
}