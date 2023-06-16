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
    public partial class MyStaff : Form
    {
        int Employee_ID;
        public MyStaff(int Employee_id)
        {
            Employee_ID = Employee_id;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminProvidedFunctionalities p = new AdminProvidedFunctionalities(Employee_ID);
            p.Show();
            this.Hide();
        }

        private void MyStaff_Load(object sender, EventArgs e)
        {

        }

        private void View_Employee_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Employee v= new View_Employee(Employee_ID);
            v.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Employee_Button_Click(object sender, EventArgs e)
        {
            AddNewEmployee n =new AddNewEmployee(Employee_ID);
            this.Hide();
            n.Show();
        }

        private void Update_Employee_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_Employee a =new update_Employee(Employee_ID);
            a.Show();
        }
    }
}
