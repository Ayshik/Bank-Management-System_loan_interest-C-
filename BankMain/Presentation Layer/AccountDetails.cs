﻿using System;
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
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentAccount sa = new StudentAccount();
            this.Visible = false;
            sa.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalAccount pa = new PersonalAccount();
            this.Visible = false;
            pa.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SavingsAccount sa = new SavingsAccount();
            this.Visible = false;
            sa.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Information i = new Information();
                this.Visible = false;
                i.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
