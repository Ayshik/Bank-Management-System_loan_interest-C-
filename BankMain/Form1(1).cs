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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                Cashier c = new Cashier();
                this.Visible = false;
                c.Visible = true;

            }
            else if (radioButton2.Checked == true)
            {
                Accountant acc = new Accountant();
                this.Visible = false;
                acc.Visible = true;

            }
            else if (radioButton3.Checked == true)
            {
                Information i = new Information();
                this.Visible = false;
                i.Visible = true;

            }
            else if (radioButton4.Checked == true)
            {
                LoanManager lm = new LoanManager();
                this.Visible = false;
                lm.Visible = true;

            }
            else
            {
                MessageBox.Show("PLEASE SELECT A TYPE OF USER");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();﻿
        }
    }
}
