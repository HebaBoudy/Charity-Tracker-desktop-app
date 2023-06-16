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
    public partial class Food_Dep : Form
    {
        int Handler_ID;
        
        public Food_Dep(int Employee_ID)
        {
            Handler_ID = Employee_ID;
            InitializeComponent();
        }

        private void Food_Dep_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(Handler_ID, "food");
            s.Show();
            this.Close();
        }

        private void viewFoodDonations_Click(object sender, EventArgs e)
        {
            ViewDonations v = new ViewDonations(Handler_ID,"food");
            v.Show();
            this.Hide();

        }

        private void pullStock_Click(object sender, EventArgs e)
        {
            PullFromStock p = new PullFromStock(Handler_ID, "food");
            p.Show();
            this.Hide();
        }
    }
}
