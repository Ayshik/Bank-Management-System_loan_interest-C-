using BankMain.Bussiness_Logic_Layer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using BankMain.Data_Acccess_Layer;






namespace BankMain
{
    public partial class Home : Form
    {

        Employee em = new Employee();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Boolean state = false;
        public Home()
        {
            InitializeComponent();
            textBox2.PasswordChar = '#';
            textBox2.MaxLength = 10;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("TextBox cannot be empty");
            }
            else
            {
                em.UserId = textBox1.Text;
                em.Password = textBox2.Text;



                {
                    if (state == false)
                    {
                        dt = da.LoginC(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Cashier c = new Cashier();
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }




                {
                    if (state == false)
                    {
                        dt = da.LoginI(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Information i = new Information();
                            this.Visible = false;
                            i.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }


                {
                    if (state == false)
                    {
                        dt = da.LoginA(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Accountant acc = new Accountant();
                            this.Visible = false;
                            acc.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }


                }

                {
                    if (state == false)
                    {
                        dt = da.LoginM(em);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
                            this.Visible = false;
                            lmp.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }


                    if (state == false)
                    {
                        MessageBox.Show("Error 69....Invalid id,No ID found in Database");
                    }



                }

            }
            


















        }























        /*if (textBox1 .Text == "1")


        {
            Cashier c = new Cashier();
            this.Visible = false;
            c.Visible = true;

        }
        else if (textBox1.Text == "2")
        {
            Accountant acc = new Accountant();
            this.Visible = false;
            acc.Visible = true;

        }
        else if (textBox1.Text == "3")
        {
            Information i = new Information();
            this.Visible = false;
            i.Visible = true;

        }
        else if (textBox1.Text == "4")
        {

            Loan_Manager_Palel lmp = new Loan_Manager_Palel();
            this.Visible = false;
            lmp.Visible = true;
        }
        else
        {
            MessageBox.Show("INVALID USERNAME");
        }*/



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
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblsecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblsecond.Location.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer.Start();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblsecond_Click(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }


}