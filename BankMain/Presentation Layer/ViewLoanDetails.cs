using BankMain.Bussiness_Logic_Layer;
using BankMain.Data_Acccess_Layer;
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

    public partial class ViewLoanDetails : Form
    {
        DataAccess d = new DataAccess();
        DataTable dt = new DataTable();
        Users uc = new Users();
        Loan l = new Loan();
        LoanData ld = new LoanData();
        public ViewLoanDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
            this.Visible = false;
            lmp.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}