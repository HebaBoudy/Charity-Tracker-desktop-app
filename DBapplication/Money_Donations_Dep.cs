using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Money_Donations_Dep : Form
    {
        int Handler_ID;
        public Money_Donations_Dep(int Employee_ID)
        {
            Handler_ID = Employee_ID;
            InitializeComponent();
        }

        private void Money_Donations_Dep_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void addMoneyDon_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(Handler_ID, "money");
            s.Show();
            this.Close();
        }

        private void viewBloodDonations_Click(object sender, EventArgs e)
        {
            ViewDonations v = new ViewDonations(Handler_ID, "money");
            v.Show();
            this.Close();
        }
    }
}
