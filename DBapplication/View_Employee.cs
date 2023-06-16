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
    public partial class View_Employee : Form
    {
        int Employee_ID;
        Controller controllerObj;
        public View_Employee(int id)
        {
            Employee_ID = id;   
            InitializeComponent();
            controllerObj= new Controller();
            dep_combobox.DataSource = controllerObj.SelectAllDepartments();
            dep_combobox.DisplayMember = "Name";
            dep_combobox.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(View_by_combobox.Text=="All")
            {
                DataTable dt = controllerObj.SelectAllEmployees();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if(View_by_combobox.Text == "By Department")
            {
                dep_combobox.Enabled = true;
 
                DataTable dt = controllerObj.SelectEmployeesByDepartmentID(Convert.ToInt32(dep_combobox.SelectedValue));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
   
            }
            else
            {
                Phone_Number_txtbx.Enabled = true;
                
                if (Phone_Number_txtbx.Text == "")
                MessageBox.Show("No Results Found ");
                DataTable dt = controllerObj.SelectEmployeesByPhoneNumber(Phone_Number_txtbx.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

        }

        private void View_Employee_Load(object sender, EventArgs e)
        {
            Phone_Number_txtbx.Enabled = false;
            dep_combobox.Enabled = false;   

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyStaff m = new MyStaff(Employee_ID);
                m.Show();
        }

        private void View_by_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (View_by_combobox.Text == "All")
            {
                Phone_Number_txtbx.Enabled = false;
                dep_combobox.Enabled = false;
            }
            else if (View_by_combobox.Text == "By Department")
            {
                dep_combobox.Enabled = true;
                Phone_Number_txtbx.Enabled = false;


            }
            else
            {
                Phone_Number_txtbx.Enabled = true;
                dep_combobox.Enabled = false;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
