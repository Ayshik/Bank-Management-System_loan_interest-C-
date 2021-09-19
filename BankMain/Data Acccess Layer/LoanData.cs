using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BankMain.Bussiness_Logic_Layer;

namespace BankMain.Data_Acccess_Layer
{
    class LoanData
    {
        SqlConnection con;

        public LoanData()
        {
            con = new SqlConnection(@"Data Source=AYSH-STAR;Initial Catalog=Bank;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void AddLoan(Loan loan)
        {
            string query = string.Format("Insert into LoanInfo([Account Number],[User Name],[Loan Type],[Loan Amount],[Pay Year],[Pay Amount]) values ('{0}','{1}','{2}','{3}','{4}','{5}')", loan.AccountNumber, loan.UserName, loan.LoanType, loan.LoanAmount, loan.RepayYear, loan.RepayAmount);
            string query1 = "UPDATE Users SET Loan= ' " + loan.RepayAmount + " '  Where [Account Number] = ' " + loan.AccountNumber + " ' ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
        }

        public void DeductLoan(Loan loan)
        {
            string query = string.Format("Update LoanInfo set [Pay Amount]='{0}' where [Account Number]='{1}'", loan.RepayAmount, loan.AccountNumber);
            string query1 = "UPDATE Users SET Loan= ' " + loan.RepayAmount + " '  Where [Account Number] = ' " + loan.AccountNumber + " ' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
        }

        //public void UpdateLoan(Loan loan)
        //{
        //    string query = string.Format("Update LoanInfo set [Pay Amount]='{0}' where [Account Number]='{1}'", loan.RepayAmount, loan.AccountNumber);
        //    string query1 = "UPDATE Users SET Loan= ' " + loan.RepayAmount + " '  Where [Account Number] = ' " + loan.AccountNumber + " ' ";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    SqlCommand cmd1 = new SqlCommand(query1, con);
        //    cmd.ExecuteNonQuery();
        //    cmd1.ExecuteNonQuery();
        //}
        public DataTable LoanDetails(Users u)
        {
            string query = string.Format("Select * from LoanInfo where [Account Number]='{0}'", u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


    }
}
