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
    public partial class Cloths_Dep : Form
    {
       
        int EmployeeID;
        public Cloths_Dep(int Employee_id)
        {
            EmployeeID = Employee_id;
            InitializeComponent();
            

        }

        private void Cloths_Dep_Load(object sender, EventArgs e)
        {

        }

        private void addClothes_Click(object sender, EventArgs e)
        {
            SearchParticipant s = new SearchParticipant(EmployeeID, "clothes");
            s.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void viewClothesDonations_Click(object sender, EventArgs e)
        {
            ViewDonations v = new ViewDonations(EmployeeID, "clothes");
            v.Show();
            this.Hide();
        }

        private void pullStock_Click(object sender, EventArgs e)
        {
            PullFromStock p = new PullFromStock(EmployeeID, "clothes");
            p.Show();
            this.Hide();
        }
    }
}
