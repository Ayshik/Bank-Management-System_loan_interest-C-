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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users u = new Users();
        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }
        private void UpAccountNumber()
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            /*u.UserName = textBox1.Text;
            u.Password = "empty";
            u.Balance = 0;
            u.DipositeDate = "0";
            u.WithdrawDate = "0";
            u.Loan = 0;
            u.Address = textBox3.Text;
            u.PhoneNumber = textBox4.Text;
            u.DOB = dateTimePicker1.Text;
            u.NationalId = textBox7.Text;
            u.Email = textBox6.Text;
            u.Gender = comboBox1.Text;
            u.AccountType = comboBox2.Text;*/



            //if (comboBox2.Text == "STUDENT ACCOUNT")
            //{
            //    u.AccountType = 1;
            //}
            //else if(comboBox2.Text == "SAVINGS ACCOUNT")
            //{
            //    u.AccountType = 2;
            //}
            //else if(comboBox2.Text == "JOINT ACCOUNT")
            //{
            //    u.AccountType = 3;
            //}
            //else
            //{
            //    u.AccountType = 4;
            //}
            if(textBox1.Text==""|| textBox3.Text==""|| textBox4.Text==""|| dateTimePicker1.Text==""|| textBox7.Text==""|| textBox6.Text==""|| comboBox1.Text=="" || comboBox2.Text==""||Validation.IsValidName(textBox1.Text)==false||Validation.IsValidEmail(textBox6.Text)==false||u.FileS==null||u.FileI==null||Validation.IsValidID(textBox4.Text)==false||Validation.IsValidID(textBox7.Text)==false)
            {
                MessageBox.Show("Value cannot be empty,image and signature cannot be empty,may be name or email address is not in valid format");
            }
            else
            {
                u.UserName = textBox1.Text;
                u.Password = "empty";
                u.Balance = 0;
                u.DipositeDate = "0";
                u.WithdrawDate = "0";
                u.Loan = 0;
                u.Address = textBox3.Text;
                u.PhoneNumber = textBox4.Text;
                u.DOB = dateTimePicker1.Text;
                u.NationalId = textBox7.Text;
                u.Email = textBox6.Text;
                u.Gender = comboBox1.Text;
                u.AccountType = comboBox2.Text;
                int i = da.CreateAccount(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                dt = da.UserDetailsAcc(u);
                if(dt.Rows.Count==1)
                {
                    label10.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Error in acc num");
                }
               
            }
            
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant acc = new Accountant();
            this.Visible = false;
            acc.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbostate.Items.Add("MALE");
           // cbostate.Items.Add("FEMALE");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                /*string picPath = f.FileName.ToString();
                textBox8.Text = picPath;
                pictureBox2.ImageLocation = picPath;*/
                u.FileI = Image.FromFile(f.FileName);
                pictureBox2.ImageLocation = f.FileName.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                /*string picPath = f.FileName.ToString();
                textBox8.Text = picPath;
                pictureBox2.ImageLocation = picPath;*/
                u.FileS = Image.FromFile(f.FileName);
                pictureBox3.ImageLocation = f.FileName.ToString();
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
