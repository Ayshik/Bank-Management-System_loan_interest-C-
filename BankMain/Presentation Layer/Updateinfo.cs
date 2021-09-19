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
    public partial class Updateinfo : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users u = new Users();
        public Updateinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accountant acc = new Accountant();
            this.Visible = false;
            acc.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            u.UserId = textBox7.Text;
            dt = da.UserDetails(u);
             /*byte[] img = (byte[])dt.Rows[0][15];
            byte[] img2 = (byte[])dt.Rows[0][11];
            MemoryStream ms = new MemoryStream(img);
            MemoryStream ms2 = new MemoryStream(img2);
           pictureBox2.Image = Image.FromStream(ms);
            pictureBox3.Image = Image.FromStream(ms2);*/
            if (dt.Rows.Count == 1)
            {
                textBox1.Text = dt.Rows[0][2].ToString();

                textBox4.Text = dt.Rows[0][4].ToString();
                textBox9.Text = dt.Rows[0][5].ToString();
                textBox5.Text = dt.Rows[0][6].ToString();
                textBox8.Text = dt.Rows[0][7].ToString();
                textBox2.Text = dt.Rows[0][8].ToString();
                textBox3.Text = dt.Rows[0][9].ToString();
               textBox6.Text = dt.Rows[0][10].ToString();
            }
                 else
            {
                MessageBox.Show("INVALID Account No");
            }
                
            
            
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = comboBox1.Text.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = comboBox2.Text.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox7.Text==""||textBox1.Text==""||textBox5.Text==""||textBox4.Text==""||textBox3.Text==""||textBox6.Text==""||textBox8.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Textfield cannont be empty");
            }
            else if(Validation.IsValidName(textBox1.Text) == false || Validation.IsValidID(textBox4.Text) == false || Validation.IsValidEmail(textBox3.Text)==false || Validation.IsValidID(textBox2.Text)==false)
            {
                MessageBox.Show("may be invalid Email,Name,ID or PhoneNumner");
            }
            else
            {
                u.UserId = textBox7.Text;
                u.UserName = textBox1.Text;

                u.Password = "empty";
                //  u.Balance = 0;
                //  u.DipositeDate = "0";
                //  u.WithdrawDate = "0";
                //  u.Loan = 0;
                u.Address = textBox5.Text;
                u.PhoneNumber = textBox4.Text;
                u.DOB = dateTimePicker1.Text.ToString();
                u.NationalId = textBox2.Text;
                u.Email = textBox3.Text;

                u.Gender = textBox6.Text;
                u.AccountType = textBox8.Text;
                int i = da.UpdateUser(u);
                if (i > 0)
                {
                    MessageBox.Show("Succesfully Updated");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox9.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

       

    

        }

    }

