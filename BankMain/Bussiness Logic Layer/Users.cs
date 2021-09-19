using BankMain.Data_Acccess_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMain.Bussiness_Logic_Layer
{ 
    public class Users
    { DataAccess da =new DataAccess();
       
        public int Number { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string AccountType { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public float Balance { get; set; }
        public float Dipsited { get; set; }
        public float Withdrawn { get; set; }
        public string AccountNumber { get; set; }
        public Image FileI { get; set; }
        public Image FileS { get; set; }
        public string LoanAmmount { get; set; }
        public string Repayyear { get; set; }
        public string Repayammount { get; set; }
        public string LoanType { get; set; }
          public string Loan_Ammount { get; set;  }
          public float Loan { get; set; }
        public string Deduct_Loan { get; set; }

        public string Loan_After_Deduction { get; set; }
          public string DipositeDate { get; set;  }

        public string WithdrawDate { get; set; }




        public string LoanAmount { get; set; }

        public string RepayYear { get; set; }

        public string RepayAmount { get; set; }
    }  
}
