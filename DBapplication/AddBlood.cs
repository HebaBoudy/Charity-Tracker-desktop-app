using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AddBlood : Form
    {
        int Employee_ID;
        Controller controllerObj;
        string PhoneNum;
        public AddBlood(int employeeID,string phonenum)
        {
            Employee_ID = employeeID;
            InitializeComponent();
            controllerObj = new Controller();
            PhoneNum = phonenum;
            destination.DataSource = controllerObj.SelectAllEstablishments();
            destination.DisplayMember = "Name";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewBlood_Click(object sender, EventArgs e)
        {
            int id;
            int donorID;
            DataTable dt = controllerObj.GenerateBloodID();
            if (dt.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
                id += 1;
            }
            else id = 1;
           
            if (destination.Text==""||comboBox1.Text=="")
            {
                MessageBox.Show("Please Fill All Fields !");
                return;
            }
           
           
          
                
                donorID = Convert.ToInt32(controllerObj.SelectParticipantIDByPhoneNumber(PhoneNum).Rows[0][0].ToString());
     
               int r = controllerObj.InsertBlood(id,Convert.ToInt32(numericUpDown1.Value),expiryDate.Text,donationDate.Text,comboBox1.Text,destination.Text,Employee_ID,donorID);
                if (r == 0)
                    MessageBox.Show("Insertion Failed!");
                else
                   
            {
                MessageBox.Show("Inserted Successfully");
                DataTable dtt = controllerObj.CheckBloodInStock(comboBox1.Text);
                if (dtt != null)
                {
                    controllerObj.AddBloodQuantity(comboBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                }
                else
                {
                    controllerObj.InsertBloodInStock(comboBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                }
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Blood_Dep b = new Blood_Dep(Employee_ID);
            b.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Blood_Dep b = new Blood_Dep(Employee_ID);
            b.Show();
            this.Close();
        }

        private void addBPrt_Click(object sender, EventArgs e)
        {
           
        }
    }
}
