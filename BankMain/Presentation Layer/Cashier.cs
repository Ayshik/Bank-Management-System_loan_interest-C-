using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMain.Bussiness_Logic_Layer;
using BankMain.Data_Acccess_Layer;
using System.IO;
namespace BankMain
{
    public partial class Cashier : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users uc = new Users();
        Boolean upd = false;
        Boolean upw = false;
        Boolean ups = false;
        Boolean upr = false;
        float Balance;
        float withdrawBalance;
        float senderBalance = 0;
        float recieverBalance = 0;

        public Cashier()
        {
            InitializeComponent();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {
            label78.Text = dateTimePicker1.Value.ToString();
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Cashier_Load(object sender, EventArgs e)
        {
            label78.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void DipositValue(String n)
        {
            uc.UserId = n;
            dt = da.UserDetails(uc);
           



            if (dt.Rows.Count == 1)
            {
          
                label25.Text = dt.Rows[0][2].ToString();
                label21.Text = dt.Rows[0][4].ToString();
                label20.Text = dt.Rows[0][5].ToString();
                label22.Text = dt.Rows[0][6].ToString();
                label19.Text = dt.Rows[0][7].ToString();
                label18.Text = dt.Rows[0][8].ToString();
                label24.Text = dt.Rows[0][9].ToString();
                label26.Text = dt.Rows[0][10].ToString();
                label64.Text = dt.Rows[0][12].ToString();
                byte[] img = (byte[])dt.Rows[0][15];
                byte[] img2 = (byte[])dt.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                MemoryStream ms2 = new MemoryStream(img2);
                pictureBox2.Image = Image.FromStream(ms);
                pictureBox3.Image = Image.FromStream(ms2);

                Balance = float.Parse(label64.Text);
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

           
            this.DipositValue(textBox1.Text);
            upd = true;
            /*uc.UserId = textBox1.Text;
            dt = da.UserDetails(uc);
            if (dt.Rows.Count == 1)
            {
                label23.Text = dt.Rows[0][0].ToString();
                label25.Text = dt.Rows[0][2].ToString();
                label21.Text = dt.Rows[0][4].ToString();
                label20.Text = dt.Rows[0][5].ToString();
                label22.Text = dt.Rows[0][6].ToString();
                label19.Text = dt.Rows[0][7].ToString();
                label18.Text = dt.Rows[0][8].ToString();
                label24.Text = dt.Rows[0][9].ToString();
                label26.Text = dt.Rows[0][10].ToString();
                label64.Text = dt.Rows[0][12].ToString();
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }*/


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }


        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            uc.UserId = textBox5.Text;
            dt = da.UserDetails(uc);
           

            if (dt.Rows.Count == 1)
            {
                label52.Text = dt.Rows[0][2].ToString();
                
                label48.Text = dt.Rows[0][4].ToString();
                label47.Text = dt.Rows[0][5].ToString();
                label49.Text = dt.Rows[0][6].ToString();
                label46.Text = dt.Rows[0][7].ToString();
                label45.Text = dt.Rows[0][8].ToString();
                label51.Text = dt.Rows[0][9].ToString();
                label53.Text = dt.Rows[0][10].ToString();
                label67.Text = dt.Rows[0][12].ToString();
                byte[] img = (byte[])dt.Rows[0][15];
                byte[] img2 = (byte[])dt.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                MemoryStream ms2 = new MemoryStream(img2);
                pictureBox6.Image = Image.FromStream(ms);
                pictureBox5.Image = Image.FromStream(ms2);

                senderBalance = float.Parse(label67.Text);
               
            }
            else
            {
                MessageBox.Show("INVALID Account No");
               
            }
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            uc.UserId = textBox6.Text;
            dt = da.UserDetails(uc);
           
            if (dt.Rows.Count == 1)
            {
                label80.Text = dt.Rows[0][2].ToString();
               
               label76.Text = dt.Rows[0][4].ToString();
                label75.Text = dt.Rows[0][5].ToString();
                label77.Text = dt.Rows[0][6].ToString();
                label74.Text = dt.Rows[0][7].ToString();
                label73.Text = dt.Rows[0][8].ToString();
                label79.Text = dt.Rows[0][9].ToString();
                label81.Text = dt.Rows[0][10].ToString();
                label71.Text = dt.Rows[0][12].ToString();
                byte[] img = (byte[])dt.Rows[0][15];
                byte[] img2 = (byte[])dt.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                MemoryStream ms2 = new MemoryStream(img2);
                pictureBox8.Image = Image.FromStream(ms);
                pictureBox7.Image = Image.FromStream(ms2);
                recieverBalance = float.Parse(label71.Text);
                
            }
            else
            {
                MessageBox.Show("INVALID Account No");
               
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        void UpSenderBalance(String n)
        {
            uc.UserId = n;
            dt = da.UserDetails(uc);
            if (dt.Rows.Count == 1)
            {
                senderBalance = float.Parse(dt.Rows[0][12].ToString());
                ups = true;
            }
            else
            {
                ups = false;
                MessageBox.Show("INVALID Sender Account No");
            }
        }
        void UpRecieverBalance(String n)
        {
            uc.UserId = n;
            dt = da.UserDetails(uc);
            if (dt.Rows.Count == 1)
            {
                recieverBalance = float.Parse(dt.Rows[0][12].ToString());
                upr = true;
            }
            else
            {
                upr = false;
                MessageBox.Show("INVALID Recieber Account No");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            /*if (ups == false)
            {
                this.UpSenderBalance(textBox5.Text);

            }
            if (upr == false)
            {
                this.UpRecieverBalance(textBox6.Text);

            }*/
            if (textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || float.Parse(textBox7.Text) < 0||textBox5.Text==textBox6.Text)
            {
                MessageBox.Show("value cannot be o or null and reciever id cannot be same as sender id");
                upr = false;
                ups = false;
                //return;
            }
            else 
            {
                this.UpSenderBalance(textBox5.Text);
                this.UpRecieverBalance(textBox6.Text);
            }

            if ((ups == true && upr == true)  && (float.Parse(textBox7.Text) < senderBalance))
            {
                
                    uc.UserId = textBox5.Text;
                    uc.Withdrawn = float.Parse(textBox7.Text);
                    uc.Balance = (senderBalance) - uc.Withdrawn;
                    i = da.UpdateWithdraw(uc);
                    if (i > 0)
                    {
                        MessageBox.Show("Sent by Sender "+textBox5.Text+","+textBox7.Text+"Taka");
                        //this.WithdrawValue(textBox5.Text);
                        i = 0;
                    /*upr = false;
                    ups = false;*/
                    
                }
                    else
                    {
                        MessageBox.Show("Error");
                        upr = false;
                        ups = false;
                    }
                }
            if ((ups == true && upr == true)  && (float.Parse(textBox7.Text) < senderBalance))
                {
                    uc.UserId = textBox6.Text;
                    uc.Dipsited = float.Parse(textBox7.Text);
                    uc.Balance = recieverBalance + uc.Dipsited;
                    i = da.UpdateDiposit(uc);
                    if (i > 0)
                    {
                        MessageBox.Show("Recieved by Reciever " + textBox6.Text + "," + textBox7.Text + "Taka");
                        i = 0;
                        upr = false;
                        ups = false;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        upr = false;
                        ups = false;
                    }
                }
            
            }
            



        
        private void WithdrawValue(String n)
        {
            uc.UserId = textBox4.Text;
            dt = da.UserDetails(uc);
           
            if (dt.Rows.Count == 1)
            {
                label34.Text = dt.Rows[0][2].ToString();
              
                label30.Text = dt.Rows[0][4].ToString();
                label29.Text = dt.Rows[0][5].ToString();
                label31.Text = dt.Rows[0][6].ToString();
                label28.Text = dt.Rows[0][7].ToString();
                label27.Text = dt.Rows[0][8].ToString();
                label33.Text = dt.Rows[0][9].ToString();
                label35.Text = dt.Rows[0][10].ToString();
                label65.Text = dt.Rows[0][12].ToString();
                byte[] img = (byte[])dt.Rows[0][15];
                byte[] img2 = (byte[])dt.Rows[0][11];
                MemoryStream ms = new MemoryStream(img);
                MemoryStream ms2 = new MemoryStream(img2);
                pictureBox4.Image = Image.FromStream(ms);
                pictureBox1.Image = Image.FromStream(ms2);
                withdrawBalance = float.Parse(label65.Text);
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WithdrawValue(textBox4.Text);
            upw = true;
            /*uc.UserId = textBox4.Text;
            dt = da.UserDetails(uc);
            if (dt.Rows.Count == 1)
            {
                label34.Text = dt.Rows[0][2].ToString();
                label32.Text = dt.Rows[0][0].ToString();
                label30.Text = dt.Rows[0][4].ToString();
                label29.Text = dt.Rows[0][5].ToString();
                label31.Text = dt.Rows[0][6].ToString();
                label28.Text = dt.Rows[0][7].ToString();
                label27.Text = dt.Rows[0][8].ToString();
                label33.Text = dt.Rows[0][9].ToString();
                label35.Text = dt.Rows[0][10].ToString();
                label65.Text = dt.Rows[0][12].ToString();
            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int i;
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            if (textBox1.Text == "" || textBox2.Text == "0" || textBox2.Text == "" || float.Parse(textBox2.Text) < 0)
            {
                MessageBox.Show("value cannot be null or 0");
            }
            else if (upd == false)
            {
                this.DipositValue(textBox1.Text);
                uc.Dipsited = float.Parse(textBox2.Text);
                uc.Balance = Balance + uc.Dipsited;
                i = da.UpdateDiposit(uc);
                if (i > 0)
                {
                    MessageBox.Show("Dipsited " + textBox2.Text);
                    this.DipositValue(this.textBox1.Text);
                    uc.DipositeDate = label78.Text;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                //upd = true;
            }
            else
            {
                uc.Dipsited = float.Parse(textBox2.Text);
                uc.Balance = Balance + uc.Dipsited;
                i = da.UpdateDiposit(uc);
                if (i > 0)
                {
                    MessageBox.Show("Dipsited " + textBox2.Text);
                    this.DipositValue(this.textBox1.Text);
                    uc.DipositeDate = label78.Text;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                upd = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            if (textBox4.Text == "" || textBox3.Text == "" || textBox3.Text == "0" ||float.Parse(textBox3.Text)<0)
            {
                MessageBox.Show("value cannot be null or 0 or negative");
            }
            else if (upw == false)
            {
                
                this.WithdrawValue(textBox4.Text);
                if (textBox4.Text != "" && textBox3.Text != "" && (float.Parse(textBox3.Text) > 0 && float.Parse(textBox3.Text) < withdrawBalance))
                 {
                    uc.Withdrawn = float.Parse(textBox3.Text);
                    uc.Balance = withdrawBalance - uc.Withdrawn;
                    i = da.UpdateWithdraw(uc);
                    if (i > 0)
                    {
                        MessageBox.Show("Withdrawn " + textBox3.Text);
                        this.WithdrawValue(textBox4.Text);
                        uc.WithdrawDate = dateTimePicker1.Value.ToShortDateString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                 }
               
                //upd = true;
            }
            else
            {
                if (textBox4.Text != "" && textBox3.Text != "" && (float.Parse(textBox3.Text) > 0 && float.Parse(textBox3.Text)<withdrawBalance))
                {
                    uc.Withdrawn = float.Parse(textBox3.Text);
                    uc.Balance = (withdrawBalance) - uc.Withdrawn;
                    i = da.UpdateWithdraw(uc);
                    if (i > 0)
                    {
                        MessageBox.Show("Withdrawn " + textBox3.Text);
                        this.WithdrawValue(textBox4.Text);
                        uc.WithdrawDate = dateTimePicker1.Value.ToShortDateString(); 
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                upw = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            label78.Text = dateTimePicker1.Value.ToString();
        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            label78.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Home c = new Home();
            this.Visible = false;
            c.Visible = true;
        }
    }
}
