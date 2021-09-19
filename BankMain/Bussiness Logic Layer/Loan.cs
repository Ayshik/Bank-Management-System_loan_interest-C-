using BankMain.Data_Acccess_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMain.Bussiness_Logic_Layer
{
    public class Loan : Users
    {
        //public string LoanAmount { get; set; }
        //public string RepayYear { get; set; }
        //public string RepayAmount { get; set; }
        //public string LoanType { get; set; }
        //public string Loan_Ammount { get; set; }
        //public string Deduct_Loan { get; set; }
        public double Loan_After_Deduction { get; set; }

        public void AddLoan()
        {
            LoanData ld = new LoanData();
            ld.AddLoan(this);
        }

        public void DeductLoan()
        {
            LoanData ld = new LoanData();
            ld.DeductLoan(this);

            //Loan_After_Deduction = double.Parse(RepayAmount) - double.Parse(Deduct_Loan);
            //RepayAmount = Loan_After_Deduction.ToString();

            //ld.UpdateLoan(this);
        }

    }
}
