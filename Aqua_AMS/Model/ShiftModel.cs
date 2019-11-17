using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_AMS.Model
{
 public   class ShiftModel : IShiftModel
    {
        public int ShiftID { get; set; }
        public string ShiftName { get; set; }

        public DateTime Date { get; set; }
    }
}
