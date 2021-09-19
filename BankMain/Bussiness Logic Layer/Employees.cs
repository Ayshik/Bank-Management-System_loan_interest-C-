using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMain.Data_Acccess_Layer;

namespace BankMain.Bussiness_Logic_Layer
{
    class Employees
    {
        public int Number { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        DataAccess da = new DataAccess();
        Employees e;

    }
}
