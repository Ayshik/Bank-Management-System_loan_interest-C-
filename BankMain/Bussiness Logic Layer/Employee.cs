using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMain.Data_Acccess_Layer;
using BankMain.Bussiness_Logic_Layer;
using System.Drawing;

namespace BankMain.Bussiness_Logic_Layer
{
    public class Employee
    {
        public int Number { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public Image File { get; private set; }
        
    }
}
