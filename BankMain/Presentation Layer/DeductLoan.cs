using BankMain.Bussiness_Logic_Layer;
using BankMain.Data_Acccess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMain
{
    public partial class DeductLoan : Form
    {
        DataTable dt = new DataTable();
        DataAccess da = new DataAccess();
        Users uc = new Users();
        LoanData ld = new LoanData();
        public DeductLoan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
            this.Visible = false;
            lmp.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            uc.UserId = textBox1.Text;
            dt = da.UserDetails(uc);
            byte[] img = (byte[])dt.Rows[0][15];
            byte[] img2 = (byte[])dt.Rows[0][11];
            MemoryStream ms = new MemoryStream(img);
            MemoryStream ms2 = new MemoryStream(img2);
            pictureBox6.Image = Image.FromStream(ms);
            pictureBox5.Image = Image.FromStream(ms2);
            if (dt.Rows.Count == 1)
            {
                label25.Text = dt.Rows[0][2].ToString();
                label23.Text = dt.Rows[0][1].ToString();
                label22.Text = dt.Rows[0][6].ToString();
                label21.Text = dt.Rows[0][4].ToString();
                label20.Text = dt.Rows[0][5].ToString();
                label18.Text = dt.Rows[0][7].ToString();
                label18.Text = dt.Rows[0][8].ToString();
                label7.Text = dt.Rows[0][9].ToString();
                label8.Text = dt.Rows[0][10].ToString();
                label64.Text = dt.Rows[0][12].ToString();
                label5.Text = dt.Rows[0][18].ToString();
                label6.Text = dt.Rows[0][7].ToString();

            }

            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double newLoan = double.Parse(label5.Text) - double.Parse(textBox2.Text);
            if (newLoan >= 0)
            {
                label24.Text = newLoan.ToString();
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label24.Text != "-")
            {
                Loan loan = new Loan();
                loan.AccountNumber = textBox1.Text;
                loan.RepayAmount = label24.Text;
                //loan.Deduct_Loan = textBox2.Text;
                loan.DeductLoan();
                label5.Text = loan.RepayAmount;
                textBox2.Text = "";
                label24.Text = "-";
                MessageBox.Show("Loan Deduction Completed");
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }
    }
}
