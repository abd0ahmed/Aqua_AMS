using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aqua_AMS.Model
{
    public class UserModel : IUserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public String FristName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int UserRole { get; set; }
        public string Password { get; set; }

    }
}
