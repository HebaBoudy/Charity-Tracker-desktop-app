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
    public partial class Blood_Dep : Form
    {
        int Handler_ID;
        
        public Blood_Dep(int Employee_id)
        {
            Handler_ID = Employee_id;
            InitializeComponent();
            
          

        }

        private void Blood_Dep_Load(object sender, EventArgs e)
        {

        }

        private void addBloodDon_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(Handler_ID, "blood");
            s.Show();
            this.Close();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewDonations v = new ViewDonations(Handler_ID,"blood");
            v.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pullStock_Click(object sender, EventArgs e)
        {
            PullFromStock p = new PullFromStock(Handler_ID,"blood");
            p.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
