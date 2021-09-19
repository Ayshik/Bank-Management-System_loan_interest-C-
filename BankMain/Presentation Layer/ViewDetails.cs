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
    public partial class ViewDetails : Form
    {
        public ViewDetails()
        {
            InitializeComponent();
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

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bankDataSet.Users);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
