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
    public partial class Books_Dep : Form
    {
        
        int EmployeeID;
        public Books_Dep(int Employee_id)
        {
            EmployeeID = Employee_id;
            InitializeComponent();
           

        }

        private void Books_Dep_Load(object sender, EventArgs e)
        {

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(EmployeeID, "books");
            s.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void viewBookDonations_Click(object sender, EventArgs e)
        {
            ViewDonations v = new ViewDonations(EmployeeID, "books");
            v.Show();
            this.Hide();
        }

        private void pullStock_Click(object sender, EventArgs e)
        {
            PullFromStock p = new PullFromStock(EmployeeID, "books");
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(EmployeeID, "books");
            s.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  MyStaff m = new MyStaff(Employee_ID);
           // m.Show();
        }
    }
}
