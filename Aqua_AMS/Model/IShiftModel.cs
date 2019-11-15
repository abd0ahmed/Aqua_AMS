using System;

namespace Aqua_AMS.Model
{
  public  interface IShiftModel
    {
        DateTime Date { get; set; }
        int ShiftID { get; set; }
        string ShiftName { get; set; }
    }
}