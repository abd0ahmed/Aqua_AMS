using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_AMS.Model
{
   public class ParentsModel : IParentsModel
    {
        public int ParentID { get; set; }
        public string ParentName { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public string address { get; set; }
        public string ParentSSn { get; set; }
    }
}
