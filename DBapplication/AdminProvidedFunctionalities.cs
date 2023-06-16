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
    public partial class AdminProvidedFunctionalities : Form
    {
       int  Employee_ID;
        public AdminProvidedFunctionalities(int Employee_id)
        {
            InitializeComponent();
            Employee_ID = Employee_id;  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w = new welcome();
            w.Show();
        }

        private void AdminProvidedFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void Managerial_Reports_Click(object sender, EventArgs e)
        {
            Managerial_Reports m=new Managerial_Reports();
            this.Hide();
            m.Show();
        }
       
        private void Establishment_Button_Click(object sender, EventArgs e)
        {
            Establishments v=new Establishments(Employee_ID);
            v.Show();
            this.Hide();
        }

        private void Staff_Button_Click_1(object sender, EventArgs e)
        {
            MyStaff staff=new MyStaff(Employee_ID);
            staff.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Close();
        }

        private void myBusses_Click(object sender, EventArgs e)
        {
            MyBusses b = new MyBusses(Employee_ID);
            b.Show();
            this.Hide();
        }
    }
}
