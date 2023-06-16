using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DBapplication
{
    public partial class AddNewEmployee : Form
    {
        Controller ControllerObj;
        int EmployeeID;
        public AddNewEmployee(int id)
        {
            ControllerObj = new Controller();
            EmployeeID = id;
            InitializeComponent();
            Dep_Combobox.DataSource = ControllerObj.SelectAllDepartments();
            Dep_Combobox.DisplayMember = "Name";
            Dep_Combobox.ValueMember = "ID";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyStaff s = new MyStaff(EmployeeID);
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GenerateID();
            int id = Convert.ToInt32(dt.Rows[0][0]);
            id = id + 1;
            

            if (FName.Text == "" || MName.Text == "" || LName.Text == "" || Phone.Text == "" || (Female.Checked == false && Male.Checked == false))
            {
                MessageBox.Show(" Missing Data ! ");
                return;
            }
            if (Phone.TextLength != 11)
            {
                MessageBox.Show(" Incorrect Phone Number, Try again . ");
                return;
            }
            if (UserName.Text == ""&&UserName.Enabled==true)
            {
                MessageBox.Show(" Please Enter a Username ! ");
                return;
            }
           
            string gender;
            if (Female.Checked)
                gender = "F";
            else
                gender = "M";

            if (UserName.Enabled == true)
            {
                DataTable dtt = ControllerObj.IsUsernameExists(UserName.Text);
                if (dtt != null)
                {
                    MessageBox.Show("This UserName is already Taken !");
                }
                else
                {

                    int flag2 = ControllerObj.InsertEmployee(id, FName.Text, MName.Text, LName.Text, Phone.Text, Convert.ToInt32(AgeDropDown.Value), gender, Convert.ToInt32(SalaryNumericUpDown.Value), Convert.ToInt32(Dep_Combobox.SelectedValue), Email.Text, Convert.ToInt32(WorkingHoursDrop.Value));

                    int flag = ControllerObj.InsertIntoU_login(id, Convert.ToInt32(Dep_Combobox.SelectedValue), UserName.Text);

                    if (flag == 0 || flag2 == 0)
                        MessageBox.Show("Insertion Failled");
                    else

                        MessageBox.Show("Inserted Successfully !");

                }
            }
            else
            {
                int flag2 = ControllerObj.InsertEmployee(id, FName.Text, MName.Text, LName.Text, Phone.Text, Convert.ToInt32(AgeDropDown.Value), gender, Convert.ToInt32(SalaryNumericUpDown.Value), Convert.ToInt32(Dep_Combobox.SelectedValue), Email.Text, Convert.ToInt32(WorkingHoursDrop.Value));

                

                if ( flag2 == 0)
                    MessageBox.Show("Insertion Failled");
                else

                    MessageBox.Show("Inserted Successfully !");
            }

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dep_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dep_Combobox.Text == "Drivers Department" || Dep_Combobox.Text == "Cleaning Department")
            {
                UserName.Enabled = false;
            }
            else
            {
                UserName.Enabled = true;
            }
        }
    }
}