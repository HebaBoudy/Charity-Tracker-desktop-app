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
    public partial class update_Employee : Form
    {
        
        int Employee_ID;
        Controller controllerObject;
        public update_Employee(int id)
        {
            InitializeComponent();
            Employee_ID = id;
            controllerObject = new Controller();
            dep_combobox.DataSource = controllerObject.SelectAllDepartments();
            dep_combobox.DisplayMember = "Name";
            dep_combobox.ValueMember = "ID";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyStaff m = new MyStaff(Employee_ID);
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (phoneNum_txtbx.Text == "")
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            int x=2, y=2, z=2, a=2,b=2;
           

            if (dep_combobox.Text != controllerObject.SelectDepartmentByPhoneNumber(phoneNum_txtbx.Text).ToString())
            {
                y = controllerObject.UpdateEmployeeDepartment(Convert.ToInt32(dep_combobox.SelectedValue), phoneNum_txtbx.Text);
                if (y == 0)
                    MessageBox.Show("Cannot update Department");
                else
                    controllerObject.UpdateU_LoginDepartment(Convert.ToInt32(dep_combobox.SelectedValue),phoneNum_txtbx.Text);
            }
            if (numericUpDown1.Value != 0)
            {
                z = controllerObject.UpdateEmployeeSalaryByPhoneNumber(Convert.ToInt32(numericUpDown1.Value), phoneNum_txtbx.Text);
                if (z == 0)
                    MessageBox.Show("Can't update Salary");

            }
            if (hrs.Value != 0)
            {
                a = controllerObject.UpdateEmployeeHrsByPhoneNumber(Convert.ToInt32(hrs.Value), phoneNum_txtbx.Text);
                if (a == 0)
                    MessageBox.Show("Can't update Working hours ");
            }
            if(email.Text!="")
            {
                b = controllerObject.UpdateEmployeeEmailByPhoneNumber(email.Text, phoneNum_txtbx.Text);
                if (b == 0)
                    MessageBox.Show("Cannot update Email");
         
            }
            if (newPhoneNum.Text != "")
            {
                if (newPhoneNum.TextLength != 11)
                {
                    MessageBox.Show("Please enter a valid Phone Number !");
                    return;
                }
                
                x = controllerObject.UpdateEmployeePhoneNumber(phoneNum_txtbx.Text, newPhoneNum.Text);
               
                if (x == 0)
                { MessageBox.Show("Cannot update phone Number"); return; }
                phoneNum_txtbx.Text = newPhoneNum.Text;
            }
            if (a != 0 && b != 0 && x != 0 && y != 0 && z != 0)
            {
                MessageBox.Show("Selected fields are updated successfully");
                DataTable dt = controllerObject.SelectEmployeesByPhoneNumber(phoneNum_txtbx.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }

        }

        private void phoneNum_txtbx_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (phoneNum_txtbx.Text == "")
            MessageBox.Show("Please enter a Number ");
            if(phoneNum_txtbx.TextLength!=11)
                MessageBox.Show("Please enter a valid Number ");
            DataTable dt = controllerObject.SelectEmployeesByPhoneNumber(phoneNum_txtbx.Text);
            dataGridView1.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("No Results");
                return;
            }
            dep_combobox.SelectedValue = dt.Rows[0][8];
           dataGridView1.Refresh();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = controllerObject.DeleteEmployeeByPhoneNumber(phoneNum_txtbx.Text);
            if (x == 0)
                MessageBox.Show("Deletion Failed");
            else
            {
                MessageBox.Show("Deletion Successfully!");
                controllerObject.DeleteFromU_Login();
            }
               

        }

        private void dep_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
