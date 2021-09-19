using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMain
{
    public partial class Loan_Manager_Palel : Form
    {
        public Loan_Manager_Palel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoanManager lm = new LoanManager();
             this.Visible = false;
            lm.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewLoanDetails vld = new ViewLoanDetails();
            this.Visible = false;
            vld.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeductLoan dl = new DeductLoan();
            this.Visible = false;
            dl.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           ManagerTransection mt=new ManagerTransection();
           this.Visible = false;
           mt.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
