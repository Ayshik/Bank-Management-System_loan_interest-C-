
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BankMain.Bussiness_Logic_Layer;
using System.IO;


namespace BankMain.Data_Acccess_Layer
{
    public class DataAccess
    {
        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=AYSH-STAR;Initial Catalog=Bank;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public DataTable LoginC(Employee e)
        {
            string query = string.Format("Select * from Cashier where UserId= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LoginI(Employee e)
        {
            string query = string.Format("Select * from InfoManager where UserId= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable LoginA(Employee e)
        {
            string query = string.Format("Select * from Accountents where UserId= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LoginM(Employee e)
        {
            string query = string.Format("Select * from LoanManager where UserId= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable UserDetails(Users u)
        { 
            string query = string.Format("Select * from Users where [Account Number]='{0}'",u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
           //con.Close();
            return dt;
        }
        public int CreateAccount(Users u)
        {
            int i = 0;
            string query = "INSERT INTO Users([Full Name],Password,[Phone Number],DOB,Address,[Account Type],[National Id],Email,Gender,Signeture,Balance,Pic,[Diposite Date],[Withdraw Date],Loan) VALUES (' " + u.UserName + " ',' " + u.Password + " ', ' " + u.PhoneNumber + " ', ' " + u.DOB + " ',' " + u.Address + " ',' " + u.AccountType + " ',' " + u.NationalId + " ',' " + u.Email + " ', ' " + u.Gender + " ', @Sig, ' " + u.Balance + " ',@Pict, ' " + u.DipositeDate + " ', ' " + u.WithdrawDate + " ', ' " + u.Loan + " ')";
            SqlCommand cmd = new SqlCommand(query, con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
            u.FileS.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
            u.FileI.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] p1 = stream1.ToArray();
            byte[] p2 = stream2.ToArray();
            cmd.Parameters.AddRange(new[]
                {
                     new SqlParameter("@Sig", p1),
                     new SqlParameter("@Pict", p2)
                });
             i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }
        public int UpdateDiposit(Users u)
        {
            int i = 0;
            string query = string.Format("UPDATE users SET Diposited='{0}', Balance='{1}',[Diposite Date]='{2}' WHERE [Account Number]={3}", u.Dipsited, u.Balance,u.DipositeDate, u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            i=cmd.ExecuteNonQuery();
            //con.Close();
            return i;
        }
        public int UpdateWithdraw(Users u)
        {
            int i = 0;
            string query = string.Format("UPDATE users SET Withdrawn='{0}', Balance='{1}',[Withdraw Date]='{2}' WHERE [Account Number]={3}", u.Withdrawn, u.Balance,u.WithdrawDate, u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;
        }
        public bool Delete(Users u)
        {
            
            string query = string.Format("DELETE FROM Users WHERE [Account Number] ={0}", u.AccountNumber);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();
            if (rows >= 0)
            {
                return true;
            }
            return false;
 
        }

        //public int UpdateAccount(Users u)
        //{
        //    int i = 0;
        //    string query = "UPDATE Users SET [Full Name]='{0}',Password='{1}',[Phone Number]='{2}',Email='{3}',Gender='{4}',UserId='{5}',[Account Type]='{6}',[National Id]='{7}',Signeture={8},Pic={9}) WHERE [Account Number] = {10}",u.UserName, u.Password, u.PhoneNumber,u.Email, u.Gender, u.UserId,u.AccountType,u.NationalId,"@Sig","@Pict";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    MemoryStream stream1 = new MemoryStream();
        //    MemoryStream stream2 = new MemoryStream();
        //    u.FileS.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    u.FileI.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    byte[] p3 = stream1.ToArray();
        //    byte[] p4 = stream2.ToArray();
        //    cmd.Parameters.AddRange(new[]
        //        {
        //             new SqlParameter("@Sig", p3),
        //             new SqlParameter("@Pict", p4)
        //        });
        //    i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return i;
        //}
        /*public int UpdateUser(Users u)
        {
            int i = 0;
            string query = "UPDATE Users SET [Full Name]=@FName,Password=@Pass,[Phone Number]=@PNum,Email=@Email,Gender=@Gender,[Account Type]=@AType,[National Id]=@NId,DOB=@Db,Signeture=@Sig,Pic=@Pict WHERE [Account Number] = '" + u.UserId + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
            u.FileS.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
            u.FileI.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] p3 = stream1.ToArray();
            byte[] p4 = stream2.ToArray();
            cmd.Parameters.AddRange(new[]
             {
                 new SqlParameter("@Sig", p3),
                 new SqlParameter("@Pict", p4),
                 new SqlParameter("@FName",u.UserName),
                 new SqlParameter("@Pass",u.Password),
                 new SqlParameter("@PNum",u.PhoneNumber),
                 new SqlParameter("@Email",u.Email),
                 new SqlParameter("@Gender",u.Gender),
                 //new SqlParameter("@UId",u.UserId),
                 new SqlParameter("@AType",u.AccountType),
                 new SqlParameter("@NId",u.NationalId),
                  new SqlParameter("@Db",u.DOB),
                 
        });
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }*/
        public DataTable UserDetailsAcc(Users u)
        {
            string query = string.Format("SELECT TOP(1000) [Account Number] FROM[Bank].[dbo].[Users] where[Phone Number] = ' " + u.PhoneNumber + " ' and Address= ' " + u.Address + " ' and [Account Type]=' " + u.AccountType + " ' and [National Id]=' " + u.NationalId + " ' and DOB=' " + u.DOB + " ' and Email=' " + u.Email + " ' and Gender=' " + u.Gender + " ' and [Full Name]=' " + u.UserName + " '");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }
        public int UpdateUser(Users u)
        {
            int i = 0;
            string query = String.Format("UPDATE Users SET [Full Name]='" + u.UserName + "',Password='" + u.Password + "',[Phone Number]='" + u.PhoneNumber + "',Email='" + u.Email + "',Gender='" + u.Gender + "',[Account Type]='" + u.AccountType + "',Address='"+u.Address+"',DOB='"+u.DOB+ "',[National Id]='"+u.NationalId+"' WHERE [Account Number]='" + u.UserId + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }
      
    }

      
    }

      

       
    

