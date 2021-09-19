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
    public partial class DeleteAccount : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        Users uc = new Users();
        Boolean dlt = false;
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Visible = false;
            h.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accountant acc = new Accountant();
            this.Visible = false;
            acc.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("value cannot be null or 0");
                }

                else
                {
                    uc.AccountNumber = (textBox1.Text);
                    da.Delete(uc);
                    MessageBox.Show("Successfully deleted");
                }
            }

            else
            {
                
            }
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uc.UserId = textBox1.Text;
            //dt = da.UserDetails(uc);
           if(Validation.IsValidID(textBox1.Text) == false)
            {
                MessageBox.Show("error");
            }
           else
            {
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
                }
                else
                {
                    MessageBox.Show("INVALID Account No");
                }
            }




            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
