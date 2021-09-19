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
    public partial class LoanManager : Form
    {
        DataTable dt = new DataTable();
        DataAccess da = new DataAccess();
        Users uc = new Users();
        LoanData ld = new LoanData();
        public LoanManager()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            double pastLoan = double.Parse(label9.Text);
            double newLoan = double.Parse(textBox4.Text);
            double totalLoan = pastLoan + newLoan;

            if (label25.Text == "-")
            { MessageBox.Show("please insert account number and press show details"); }

            else if (textBox3.Text == " " || comboBox2.Text == " " || textBox4.Text == " " || comboBox1.Text == " ")
            { MessageBox.Show("please insert all the value properly"); }

            else if (totalLoan < 0)
            {
                MessageBox.Show("Invalid loan input");
            }

            else if (totalLoan > 100000)
            {
                MessageBox.Show("Loan limit is maximum");
            }

            else if (loan.RepayAmount == "" || loan.RepayAmount == "0")
            {

                loan.AccountNumber = label23.Text;
                loan.UserName = label25.Text;
                loan.LoanType = comboBox2.Text;
                loan.LoanAmount = textBox3.Text;
                loan.RepayYear = comboBox1.Text;
                loan.RepayAmount = textBox4.Text;

                loan.AddLoan();
                label9.Text = loan.RepayAmount;
                MessageBox.Show("Loan is provided");
            }

            else if (pastLoan >= 0 && totalLoan < 100000)
            {
                loan.AccountNumber = label23.Text;
                loan.UserName = label25.Text;
                loan.LoanType = comboBox2.Text;
                loan.LoanAmount = textBox3.Text;
                loan.RepayYear = comboBox1.Text;
                loan.RepayAmount = totalLoan.ToString();

                loan.AddLoan();
                label9.Text = loan.RepayAmount;
                MessageBox.Show("Loan is provided");
                LoanManager lm = new LoanManager();
                this.Visible = false;
                lm.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
            this.Visible = false;
            lmp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uc.UserId = textBox1.Text;
            dt = da.UserDetails(uc);
           
            if (dt.Rows.Count == 1)
            {
                label23.Text = dt.Rows[0][1].ToString();
                label25.Text = dt.Rows[0][2].ToString();
                label21.Text = dt.Rows[0][4].ToString();
                label20.Text = dt.Rows[0][5].ToString();
                label22.Text = dt.Rows[0][6].ToString();

                label18.Text = dt.Rows[0][8].ToString();
                label24.Text = dt.Rows[0][9].ToString();
                label26.Text = dt.Rows[0][10].ToString();
                label64.Text = dt.Rows[0][12].ToString();
                label19.Text = dt.Rows[0][7].ToString();
                label9.Text = dt.Rows[0][18].ToString();
                byte[] img = (byte[])dt.Rows[0][15];
                byte[] img2 = (byte[])dt.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                MemoryStream ms2 = new MemoryStream(img2);
                pictureBox6.Image = Image.FromStream(ms);
                pictureBox5.Image = Image.FromStream(ms2);
            }

            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "CAR LOAN")
            {

                double x = Convert.ToDouble(textBox3.Text) + ((Convert.ToDouble(textBox3.Text) * 0.1) * Convert.ToDouble(comboBox1.Text));
                textBox4.Text = Convert.ToString(x);

            }
            else if (comboBox2.Text == "HOME LOAN")
            {
                double x = Convert.ToDouble(textBox3.Text) + ((Convert.ToDouble(textBox3.Text) * 0.1) * Convert.ToDouble(comboBox1.Text));
                textBox4.Text = Convert.ToString(x);

            }
            else if (comboBox2.Text == "STUDY LOAN")
            {
                double x = Convert.ToDouble(textBox3.Text) + ((Convert.ToDouble(textBox3.Text) * 0.1) * Convert.ToDouble(comboBox1.Text));
                textBox4.Text = Convert.ToString(x);

            }
            else if (comboBox2.Text == "BUSINESS LOAN")
            {
                double x = Convert.ToDouble(textBox3.Text) + ((Convert.ToDouble(textBox3.Text) * 0.1) * Convert.ToDouble(comboBox1.Text));
                textBox4.Text = Convert.ToString(x);

            }
            else
            {
                MessageBox.Show("please fill all Type");

            }

        }


    
        

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}